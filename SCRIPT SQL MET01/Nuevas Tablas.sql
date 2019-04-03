
create table met01_correlativo(
correlativo number,
correlativo_actual number,
descripcion varchar2(50),
	"ESTADO_REGISTRO" CHAR(1 BYTE), 
	"USUARIO_CREACION" VARCHAR2(50 BYTE), 
	"FECHA_CREACION" DATE, 
	"USUARIO_MODIFICACION" VARCHAR2(50 BYTE), 
	"FECHA_MODIFICACION" DATE, 
  constraint pk_cor primary key(correlativo)
);




  CREATE TABLE "MET01"."MET01_RECIBO_OFICINA" 
   (	"RECIBO" NUMBER,
   "RECIBO_OFICINA" VARCHAR2(100 BYTE), 
	"NOMBRE" VARCHAR2(250 BYTE), 
	"TOTAL" NUMBER, 
	"TOTAL_LETRAS" VARCHAR2(500 BYTE), 
	"CONCEPTO" VARCHAR2(500 BYTE), 
	"EVENTO" NUMBER, 
	"IGLESIA" NUMBER, 
	"ESTADO_REGISTRO" CHAR(1 BYTE), 
	"USUARIO_CREACION" VARCHAR2(50 BYTE), 
	"FECHA_CREACION" DATE, 
	"USUARIO_MODIFICACION" VARCHAR2(50 BYTE), 
	"FECHA_MODIFICACION" DATE, 
	 CONSTRAINT "PK_REC_OFI" PRIMARY KEY ("RECIBO"),
   	 CONSTRAINT "FK_REC_EVE" FOREIGN KEY ("EVENTO")
	  REFERENCES "MET01"."MET01_EVENTO" ("EVENTO") ENABLE, 
	 CONSTRAINT "FK_REC_IGLE" FOREIGN KEY ("IGLESIA")
	  REFERENCES "MET01"."MET01_IGLESIA" ("IGLESIA") ENABLE);
    
    

