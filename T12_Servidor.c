#include <string.h>
#include <unistd.h>
#include <stdlib.h>
#include <sys/types.h>
#include <sys/socket.h>
#include <netinet/in.h>
#include <stdio.h>
#include <mysql.h>
#include <ctype.h>
#include <pthread.h>
//Conexion global BBDD
MYSQL *conn;
//Estructura necesaria para acceso excluyente
pthread_mutex_t mutex= PTHREAD_MUTEX_INITIALIZER;
int i;
int sockets[100];


typedef struct {
	char nombre [20];
	int socket;
}Conectado;

typedef struct{
	Conectado conectados [100];
	int num;
} ListaConectados;

ListaConectados miLista;
ListaConectados Jugando;
//Consulta_1
void Consulta_1 (char respuesta[512], char nombre [20])
{
	// Consulta 1:
	// BUSCA LOS JUGADORES CON LOS QUE HA JUGADO LA PERSONA QUE INTRDUCES POR CONSOLA
	char consulta [512];
	int err;
	MYSQL_RES *resultado;
	MYSQL_ROW row;
	
	strcpy(consulta,"SELECT DISTINCT JUGADOR.ID FROM(PARTIDA, JUGADOR, CONNECTOR) WHERE PARTIDA.ID IN (SELECT PARTIDA.ID FROM(PARTIDA, JUGADOR, CONNECTOR) WHERE JUGADOR.ID= '");
	strcat(consulta,nombre);
	strcat(consulta,"' AND JUGADOR.ID= CONNECTOR.ID_J AND CONNECTOR.ID_P=PARTIDA.ID) AND PARTIDA.ID= CONNECTOR.ID_P AND CONNECTOR.ID_J=JUGADOR.ID AND JUGADOR.ID NOT IN ('");
	strcat(consulta,nombre);
	strcat(consulta,"')"); 
	
	printf("%s\n",consulta);
	// Establece connexión con la base de datos
	err=mysql_query (conn, consulta); 
	if(err!=0){
		printf("Error al consultar datos de la base \u0153u \u0153s\n", mysql_errno(conn),mysql_error(conn));
		exit(1);
	}
	//Retorna resultados de la consulta
	resultado = mysql_store_result (conn);
	row = mysql_fetch_row (resultado);
	if (row == NULL)
	{
		row[0]='0';
		sprintf (respuesta, "1/%s" , row[0]);
	}
	else
	{
		sprintf (respuesta, "1/%s", row[0]);
		row = mysql_fetch_row (resultado);
		
		while (row!=NULL)
		{
			sprintf (respuesta, "%s,%s", respuesta, row[0]); //Encadenamos la respuesta ya que puede haber jugado con mas de una persona
			
			row = mysql_fetch_row (resultado);
		}
	}
	printf("%s\n",respuesta);
}

void Consulta_2 (char respuesta[512], char nombre [20])
{
	
	// Consulta 2
	
	char consulta[512];
	int err;
	MYSQL_RES *resultado;
	MYSQL_ROW row;
	
	// BUSCA QUE JUGADOR QUE HA JUGADO EN LA PARTIDA INTRODUCIDA POR CONSOLA TIENE MAS PUNTOS ACUMULADOS
	strcpy(consulta,"SELECT DISTINCT JUGADOR.ID FROM(JUGADOR,CONNECTOR,PARTIDA) WHERE JUGADOR.TOTALPUNTS = (SELECT DISTINCT MAX(JUGADOR.TOTALPUNTS) FROM(JUGADOR, PARTIDA, CONNECTOR) WHERE CONNECTOR.ID_P = ");
	strcat(consulta,nombre);
	strcat(consulta," AND CONNECTOR.ID_J =JUGADOR.ID) AND JUGADOR.ID = CONNECTOR.ID_J AND CONNECTOR.ID_P = ");
	strcat(consulta,nombre);
	
	printf("%s\n",consulta);
	// Establece connexión con la base de datos
	err=mysql_query (conn, consulta); 
	if(err!=0){
		printf("Error al consultar datos de la base \u0153u \u0153s\n", mysql_errno(conn),mysql_error(conn));
		exit(1);
	}
	//Retorna resultados de la consulta
	resultado = mysql_store_result (conn);
	row = mysql_fetch_row (resultado);
	if (row == NULL)
	{
		printf("Row NULL\n");
		row[0]='0';
		sprintf (respuesta, "2/%s" , row[0]);
	}
	else 
	{
		sprintf (respuesta, "2/%s", row[0]);
	}
	
}

void Consulta_3 (char respuesta[512], char nombre [20])
{
	// Consulta 3
	// BUSCA LA PARTIDA MÁS CORTA Y QUE SU TIEMPO ES INFERIOR A 1500s
	char consulta [512];
	int err;
	MYSQL_RES *resultado;
	MYSQL_ROW row;
	
	strcpy (consulta,"SELECT PARTIDA.ID FROM(PARTIDA) WHERE PARTIDA.TEMPS =(SELECT MIN(PARTIDA.TEMPS) FROM PARTIDA) AND PARTIDA.TEMPS < 1500"); 
	
	// hacemos la consulta 
	err=mysql_query (conn, consulta); 
	if (err!=0) {
		printf ("Error al consultar datos de la base %u %s\n",
				mysql_errno(conn), mysql_error(conn));
		exit (1);
	}
	//recogemos el resultado de la consulta 
	resultado = mysql_store_result (conn); 
	row = mysql_fetch_row (resultado);
	if (row == NULL){
		sprintf (respuesta,"3/No se han obtenido datos en la consulta");
		printf ("No se han obtenido datos en la consulta\n");
	}
	else{
		// El resultado debe ser una matriz con una sola fila
		// y una columna que contiene el nombre
		sprintf (respuesta,"3/ID de la partida mas corta: %s", row[0] );
		printf ("ID de la partida mas corta: %s\n", row[0] );
	}
	
}

int BuscaridPartida ()
{
	char consulta [512];
	int idPartida=1;
	int err;
	MYSQL_RES *resultado;
	MYSQL_ROW row;
	
	strcpy (consulta,"SELECT PARTIDA.ID FROM(PARTIDA)"); 
	
	// hacemos la consulta 
	err=mysql_query (conn, consulta); 
	if (err!=0) {
		printf ("Error al consultar datos de la base %u %s\n",
				mysql_errno(conn), mysql_error(conn));
		exit (1);
	}
	//recogemos el resultado de la consulta 
	resultado = mysql_store_result (conn); 
	row = mysql_fetch_row (resultado);
	

		
	while (row!=NULL)
	{
		idPartida=idPartida+1;
			
		row = mysql_fetch_row (resultado);
	}
	return idPartida;
	
}


//Devolver 0, 1 -1
int LogIn ( char nombre[20], char contrasenya [20], int sock_conn)
{	
	//Poner las variables locales
	int err;
	char consulta[512];
	MYSQL_RES *resultado;
	MYSQL_ROW row;
	
	
	sprintf(consulta, "SELECT JUGADOR.CONTRASENYA FROM (JUGADOR) WHERE JUGADOR.ID ='%s'",nombre);
	
	//Realizamos la consulta
	err=mysql_query (conn, consulta); 
	if (err!=0) 
	{
		printf ("Error al consultar datos de la base %u %s\n", mysql_errno(conn), mysql_error(conn));
		exit (1);
	}
	//recogemos el resultado de la consulta 
	resultado = mysql_store_result (conn); 
	row = mysql_fetch_row (resultado);
	printf(row[0]);
	if (row == NULL)
	{
		return -1; //El usuario introducido no existe en la base de datos
		printf ("No se han obtenido datos en la consulta\n");
	}
	else
	{
		// El resultado debe ser una matriz con una sola fila
		// y una columna que contiene el nombre
		if (strcmp(row[0],contrasenya)==0)
		{	
			return 0;
			printf("La contraseña es correcta\n");
			//pthread_mutex_lock( &mutex ) ; //Thread dice: No me interrumpas ahora
/*			int resPon=0;*/
			
/*			resPon=Pon(&miLista, nombre, sock_conn);*/
/*			if (resPon==-1)*/
/*			{	return -2;*/
/*				printf("Esta llena la lista");*/
				
/*			}*/
/*			else*/
/*			{*/

/*				return 0;*/
/*				printf("Se ha añadido bien");*/
/*			}*/
			//pthread_mutex_unlock( &mutex);
		}
		
		
		
		else
		{
			return 1; //Existe el usuario introducido pero la contraseña proporcionada es incorrecta
			printf ("CONTRASENYA INCORRECTA\n");
		}
	}
	
}

int SignIn (char nombre[20], char contrasenya[20])
{
	
	int err;
	char consulta[512];
	MYSQL_RES *resultado;
	MYSQL_ROW row;
	
	strcpy(consulta,"SELECT JUGADOR.CONTRASENYA FROM (JUGADOR) WHERE JUGADOR.ID = '");
	strcat(consulta,nombre);
	strcat(consulta,"'");
	printf("%s\n",consulta);
	
	//Realizamos la consulta
	err=mysql_query (conn, consulta); 
	if (err!=0) {
		printf ("Error al consultar datos de la base %u %s\n",
				mysql_errno(conn), mysql_error(conn));
		exit (1);
	}
	//recogemos el resultado de la consulta 
	resultado = mysql_store_result (conn); 
	row = mysql_fetch_row (resultado);
	
	if (row == NULL){ //Si el usuario no existe procederá a registrarlo
		char consulta2 [1000];
		strcpy(consulta2,"INSERT INTO JUGADOR VALUES ('");
		strcat(consulta2,nombre);
		strcat(consulta2,"','");
		strcat(consulta2,contrasenya);
		strcat(consulta2,"',0)");
		printf("%s\n",consulta2);
		err=mysql_query (conn, consulta2); 
		if (err!=0) {
			return -1;
			printf ("Error al introducir los datos de la base %u %s\n",
					mysql_errno(conn), mysql_error(conn));
			exit (1);
		}
		//recogemos el resultado de la consulta 
		else{
			return 0; //Hemos podido añadir correctamente el usuario en la base de datos
			printf ("OK\n");
		}
	}
	else{
		return 1; //El usuario introducido ya existe en la base de datos, por lo tanto no lo añadimos
		printf ("YA EXISTE EL USUARIO\n");
	}
}


int Pon(ListaConectados *lista, char nombre [20], int socket){
	//Añade nuevos conectados. Retorna 0 si ok y -1 si la lista está llena (no puede añadir)
	if (lista->num==100)
		return -1;
	else{
		strcpy(lista->conectados[lista->num].nombre,nombre);
		lista->conectados[lista->num].socket=socket;
		lista->num++;
		return 0;
	}
}
int DamePosicion (ListaConectados *lista, char nombre [20]){
	//Devuelve la posicion en la lista o -1 si no está en la lista
	int i=0;
	int encontrado=0;
	
	while ((i<lista->num) && !encontrado)
	{	
		if(strcmp(lista->conectados[i].nombre, nombre)==0)
		{encontrado=1;
			printf("Lista: %s",lista->conectados[i].nombre);}
		if (!encontrado)
			i=i+1;
		
	}
	if (encontrado==1)
		return i;
	else
		return -1;
	
}

int DameSocket (ListaConectados *lista, char nombre [20]){
	//Devuelve la posicion en la lista o -1 si no está en la lista
	int i=0;
	int encontrado=0;
	
	while ((i<lista->num) && !encontrado)
	{	
		if(strcmp(lista->conectados[i].nombre, nombre)==0)
		{encontrado=1;
		printf("Lista: %s",lista->conectados[i].nombre);}
		if (!encontrado)
			i=i+1;
		
	}
	if (encontrado==1)
		return lista->conectados[i].socket;
	else
		return -1;
	
}
int Elimina (ListaConectados *lista, char nombre[20])
	//Retorna 0 si elimina y -1 si ese usuario no está en la lista
{	
	int pos= DamePosicion (lista, nombre);
	if (pos==-1)
		return -1;
	else{
		int i;
		for (i=pos; i<lista->num-1; i++)
		{	lista->conectados[i] = lista->conectados [i+1];
		}
		lista->num--;
		return 0;
	}
}

void DameConectados (ListaConectados *lista, char listaconectados [300]){
	//Pone en conectados los nombres de todos los conectados separados
	//por /. Primero pone el número de conectados. 
	sprintf (listaconectados, "%d", lista->num);
	int i;
	for (i=0; i<lista->num;i++)
		sprintf (listaconectados, "%s/%s", listaconectados, lista->conectados[i].nombre);
	
}



//Funcion abrir base de datos y que el main la llame
int contador;
//Estructura necesaria para acceso excluyente
/*pthread_mutex_t mutex= PTHREAD_MUTEX_INITIALIZER;*/

//Conectarse en Atender Cliente no en la funcion
//Proteger Elimina y pon

void *AtenderCliente (void *socket)
{	
	int err;
	// Estructura especial para almacenar resultados de consultas 
	MYSQL_RES *resultado;
	MYSQL_ROW row;
	char consulta [80];
	//Creamos una conexion al servidor MYSQL 
	conn = mysql_init(NULL);
	if (conn==NULL) {
		printf ("Error al crear la conexion: %u %s\n", mysql_errno(conn), mysql_error(conn));
		exit (1);
	}
	//inicializar la conexion
	conn = mysql_real_connect (conn, "localhost","root", "mysql", "db",0, NULL, 0);
	if (conn==NULL) {
		printf ("Error al inicializar la conexion: %u %s\n", mysql_errno(conn), mysql_error(conn));
		exit (1);
	}
	
	
	int sock_conn;
	int *s;
	s= (int *) socket;
	sock_conn= *s;
	
	char peticion[512];
	char respuesta[512];
	char nombre [20];
	int ret;

	
	int terminar =0;
	// Entramos en un bucle para atender todas las peticiones de este cliente
	//hasta que se desconecte
	
	// Entramos en un bucle para atender todas las peticiones de este cliente
	//hasta que se desconecte
	while (terminar ==0)
	{
		// Ahora recibimos la petici?n
		ret=read(sock_conn,peticion, sizeof(peticion));
		printf ("Recibido\n");
		
		// Tenemos que a?adirle la marca de fin de string 
		// para que no escriba lo que hay despues en el buffer
		peticion[ret]='\0';
		
		printf ("Peticion: %s\n",peticion);
		
		// vamos a ver que quieren
		char *p = strtok( peticion, "/");
		int codigo =  atoi (p);
		printf("numero de codigo %d\n",codigo);
		// Ya tenemos el c?digo de la petici?n
		char nombre[20];
		if ( codigo!=3 && codigo!=0 && codigo!=6 && codigo!=8 && codigo !=9 && codigo!=11)
		{
			printf("entro codigo dif0\n");
			p = strtok( NULL, "/"); //segundo trozo
			strcpy (nombre, p);
			// Ya tenemos el nombre
			printf ("Codigo: %d, Nombre: %s\n", codigo, nombre);
		}
		if (codigo==0) //Desconexión
		{
			terminar=1;
		}
/*		else if (codigo==8)*/
/*		{*/
/*			sprintf(respuesta,"%d",contador);*/
		
/*		}*/
		else if (codigo ==7) //LogOut //7??
		{	
			pthread_mutex_lock( &mutex);
			printf("Me estoy desconectando (==0)\n");
			int resElimina=Elimina(&miLista, nombre);
			printf("resElimina %d", resElimina);
			if (resElimina==0)
				printf("Se ha eliminado correctamente\n");
			terminar=1;
			pthread_mutex_unlock( &mutex);
		
			
		}
		
		
		else if (codigo ==1)
		{
			// Consulta 1:
			// BUSCA LOS JUGADORES CON LOS QUE HA JUGADO LA PERSONA QUE INTRDUCES POR CONSOLA
			//pthread_mutex_lock( &mutex ) ; //Thread dice: No me interrumpas ahora
			Consulta_1(respuesta,nombre);
			sprintf(respuesta,"%s",respuesta);
			//pthread_mutex_unlock( &mutex ) ; //Thread dice: No me interrumpas ahora
		}
		
		else if (codigo ==2) 
		{
			// Consulta 2
			// BUSCA QUE JUGADOR QUE HA JUGADO EN LA PARTIDA INTRODUCIDA POR CONSOLA TIENE MAS PUNTOS ACUMULADOS
			//pthread_mutex_lock( &mutex ) ; //Thread dice: No me interrumpas ahora
			Consulta_2(respuesta, nombre);
			sprintf(respuesta, "%s", respuesta);
			//pthread_mutex_unlock( &mutex ) ; //Thread dice: No me interrumpas ahora
			
		}
		else if (codigo ==3)
		{
			// Consulta 3
			// BUSCA LA PARTIDA MÁS CORTA Y QUE SU TIEMPO ES INFERIOR A 1500s
			
			Consulta_3(respuesta,nombre);
			sprintf(respuesta, "%s", respuesta);
			
		}
		
		else if (codigo==4) 
			// LOG IN
			// NOS PERMITE COMPROBAR SI EL USUARIO Y LA CONTRASEÑA INTRODUCIDOS EXISTEN EN LA BASE DE DATOS, EN CASO CONTRARIO NOS AVISA
		{
			
			p = strtok( NULL, "/"); //Cogemos contraseña
			char contrasenya [20];
			strcpy (contrasenya, p);
			printf("%s\n",nombre);
			printf("%s\n",contrasenya);
			
			int resLogIn=LogIn(nombre, contrasenya, sock_conn);
			if (resLogIn==-1)
				sprintf(respuesta,"NO EXISTE");
			
			else if (resLogIn==0)
			{	
				
				pthread_mutex_lock( &mutex ) ; //Thread dice: No me interrumpas ahora
				int resPon=0;
				
				resPon=Pon(&miLista, nombre, sock_conn);
				if (resPon==-1)
				{	
					
					sprintf(respuesta, "LLENO");
					printf("Esta llena la lista");
				
				}
				else
				{
					sprintf(respuesta,"OK");
					printf("Se ha añadido bien");
				}
				pthread_mutex_unlock( &mutex);
				//write (sock_conn,respuesta, strlen(respuesta));
			}
			else if (resLogIn==1)
				sprintf(respuesta, "CONTRASEÑA INCORRECTA");
			
				
		}
		
		else if (codigo==5) //SIGN IN
		{
			
			p = strtok( NULL, "/"); //Cogemos contraseña
			char contrasenya [20];
			strcpy (contrasenya, p);
			
			int resSignIn=0;
			resSignIn= SignIn(nombre, contrasenya);
			
			if (resSignIn==-1)
				sprintf(respuesta,"ERROR");
			
			else if (resSignIn==0)
				sprintf (respuesta,"OK");
			
			else if (resSignIn==1)
				sprintf (respuesta,"YA EXISTE");
			
		}
		
		else if (codigo==6) //No entra aqui
		{	//printf("Ya estoy en codigo=6\n");
			
			char misConectados[300];
			
			
			respuesta[0]='\0';
			printf("Antes de hacer la llamada\n");
			DameConectados(&miLista,misConectados);
			printf("Estos son: %s\n",misConectados);
			sprintf(respuesta,"%s", misConectados);
			
			printf("Resultado: %s\n", misConectados);
			
		}
		else if (codigo==9)
		{
			//pthread_mutex_lock( &mutex ) ; //Thread dice: No me interrumpas ahora
			p = strtok( NULL, "/");
			
			strcpy (nombre, p);
			printf("El huesped es: %s\n", nombre);
			
			char notificacion[20];
			sprintf(notificacion,"9/%s", nombre);
			//sock_conn
/*			printf("Notificacion 9:%s\n", notificacion);*/
/*			int socket=DameSocket(&miLista, nombre);*/
/*			write(socket, notificacion, strlen(notificacion));*/
			
			p=strtok(NULL, "/");
			int contador=atoi(p);
			printf("El contador vale: %d\n", contador);
			
			//p = strtok( NULL, "/");
			char invitado [20];
			//strcpy (invitado, p);
			//printf("El invitado es: %s\n", invitado);
			int j;
			
			//while (j<contador)
			//{	
				for (j=0;j<contador;j++)
				{
					p = strtok( NULL, "/"); 
					strcpy (invitado, p);
					printf("Entro en el for del codigo 9\n");
					socket=DameSocket(&miLista,invitado);
					printf("Envio codigo 9 al socket: %d\n",socket);
					
					write (socket,notificacion, strlen(notificacion));
					printf("Voy a dar otra vuelta\n");
				}
	
		}
		
		else if (codigo==10)
		{
			char notificacion[20];
			char aceptado[20];
			char persona[20];
			p=strtok(NULL, "/");
			strcpy(aceptado,p);
			p=strtok(NULL, "/");
			strcpy(persona,p);
			sprintf(notificacion, "4/%s/%s", aceptado, persona);
			int socket=DameSocket(&miLista,nombre);
			write(socket, notificacion, strlen(notificacion));
		}
		else if (codigo==11)
		{
		
			p = strtok( NULL, "/");
			
			strcpy (nombre, p);
			printf("La partida ha sido: %s\n", nombre);
			
			char notificacion[20];
			sprintf(notificacion,"5/%s", nombre);
			write(sock_conn, notificacion, strlen(notificacion));

			
			p=strtok(NULL, "/");
			int contador=atoi(p);
			printf("El contador vale: %d\n", contador);

			char invitado [20];

			int j;
			
			for (j=0;j<contador;j++)
			{
				p = strtok( NULL, "/"); 
				strcpy (invitado, p);
				printf("Entro en el for del codigo 11\n");
				socket=DameSocket(&miLista,invitado);
				printf("Envio codigo 5 al socket: %d\n",socket);
				
				write (socket,notificacion, strlen(notificacion));
				printf("Voy a dar otra vuelta\n");
			}
			
		}
		if ((codigo != 0) && (codigo != 9)&&(codigo!=10)&& (codigo!=11))
		{
			
			//Envia el mensaje a mi consola en C#
			printf("Respuesta: %s\n", respuesta);
			// Y lo enviamos
			write(sock_conn,respuesta, strlen(respuesta));// socket de conexion, respuesta, longitud de la respuesta
			
		}
		//Solo en consultas
		if ((codigo==1) || (codigo==2) || (codigo==3) ||(codigo==6) )
		{
			printf("Entrada d'on esta el mutex\n");
			pthread_mutex_lock( &mutex ) ; //Thread dice: No me interrumpas ahora
			printf("OREO 1\n");
			contador=contador+1;
			printf("OREO 2\n");
			pthread_mutex_unlock( &mutex); // Thread dice: Ya puedes interrumpirme
			printf("OREO 3\n");
			//Notificar a todos los clientes conectados
			
			char notificacion[20];
			printf("OREO 4\n");
		
			sprintf(notificacion, "8/%d", contador); //8/ pero ya se ha quitado la otra
			printf("%s\n",notificacion);
			int j;
			for(j=0; j<i; j++)
			{
				printf("Entro en for del notificacion 1236\n");
				write (sockets[j],notificacion, strlen(notificacion));
			}
			printf("Salgo del for 1236\n");
			
		}
		
		if ((codigo==4)||(codigo==7))
		{	
			//pthread_mutex_lock( &mutex ) ; //Thread dice: No me interrumpas ahora
			char notificacion[20];
			printf("OREO 4\n");
			char misConectados[300];
			
			
			respuesta[0]='\0';
			printf("Antes de hacer la llamada\n");
			DameConectados(&miLista,misConectados);
			printf("Estos son: %s\n",misConectados);
			sprintf(respuesta,"%s", misConectados);
			
			
			printf("Resultado: %s\n", misConectados);
			
			sprintf(notificacion, "6/%s", misConectados); //8/ pero ya se ha quitado la otra
			
			printf("%s\n",notificacion);
			
			int j;
			for(j=0; j<i; j++)
			{
				printf("Entro en for del notificacion 4 y 7\n");
				//Meter lista en vez de sockets
				//lista->conectados[j].socket
				int socket=miLista.conectados[j].socket;
				write (socket,notificacion, strlen(notificacion));
			}
			//pthread_mutex_unlock( &mutex ) ; //Thread dice: No me interrumpas ahora
		}
	}
	close(sock_conn);
}
int main (int argc, char *argv[]) 
{
	miLista.num=0; 
	int puerto=9227; //50085, 50086, 50087
	// CONECTAR SERVIDOR-CLIENT
	int sock_conn, sock_listen, ret;
	struct sockaddr_in serv_adr;
	char peticion[512]; //peticion buff
	char respuesta[512]; //respuesta buff2
	// INICIALITZACIONS
	// Obrim el socket
	if ((sock_listen = socket(AF_INET, SOCK_STREAM, 0)) < 0) //crear socket de escucha
		printf("Error creant socket");
	// Fem el bind al port
	contador=0;
	
	
	memset(&serv_adr, 0, sizeof(serv_adr));// inicialitza a zero serv_addr
	serv_adr.sin_family = AF_INET;
	
	// asocia el socket a cualquiera de las IP de la m?quina. 
	//htonl formatea el numero que recibe al formato necesario
	serv_adr.sin_addr.s_addr = htonl(INADDR_ANY); //indicamos a cualquier
	// escucharemos en el port 9200
	serv_adr.sin_port = htons(puerto); 
	if (bind(sock_listen, (struct sockaddr *) &serv_adr, sizeof(serv_adr)) < 0) //asociamos al socket las esecificaciones anteriores
		printf ("Error al bind\n");
	//La cola de peticiones pendientes no podr? ser superior a 4
	if (listen(sock_listen, 2) < 0) //lo ponemos en pasivo. EL 2 es el numero de objetos en cola
		printf("Error en el Listen");
	

	pthread_t thread;
	i=0;
	// Bucle infinito
	for (;;){
		printf ("Escuchando\n");
		
		sock_conn = accept(sock_listen, NULL, NULL);
		printf ("He recibido conexion\n");
		
		printf("Main socket: %d \n", sock_conn);
		//sock_conn es el socket que usaremos para este cliente
		
		sockets[i] =sock_conn;
		//sock_conn es el socket que usaremos para este cliente
		
		// Crear thead y decirle lo que tiene que hacer
		
		pthread_create (&thread, NULL, AtenderCliente,&sockets[i]);
		i=i+1;
		
	}

}



