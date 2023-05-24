using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppCurso1._1
{
    class Global
    {

        public static List<Modulos> Modulo = new List<Modulos>()
        {
            new Modulos(1,"Conceptos Básicos de las Bases de Datos"),
            new Modulos(2,"Acciones sobre una Base de Datos"),
            new Modulos(3,"Manejo de Tablas Dinámicas"),
            new Modulos(4,"Acciones sobre una Base de Datos")
        };

        public static List<Videos> Video = new List<Videos>()
        {
            new Videos(1,"Conceptos básicos de Bases de Datos en Excel | Gestión de la Información #1 ","https://goo.gl/Rof9Yf",1),
            new Videos(2,"Ejemplos de Bases de Datos en Excel | Gestión de la Información #2","https://goo.gl/iUF2rL",1),
            new Videos(3,"Diversos ejemplos de Bases de Datos en Excel | Gestión de la Información #3 ","https://goo.gl/baXcJW",1),
            new Videos(4,"¿Que es una Tabla Resumen en Excel y que es una Base de Datos? | Gestión de la Información #4 ","https://goo.gl/hj8vYo",1),
            new Videos(5,"¿Cómo ingresar datos en una Base de Datos de Excel? | Gestión de la Información #5","https://goo.gl/5kEcGd",2),
            new Videos(6,"Aprende a ordenar Bases de Datos en Excel | Gestión de la Información #6","https://goo.gl/eGZ5j9",2),
            new Videos(7,"¿Cómo generar subtotales en una Base de Datos en Excel? | Gestión de la Información #7","https://goo.gl/cq9NGR",2),
            new Videos(8,"¿Cómo se generan autofiltros en una Base de Datos en Excel? | Gestión de la Información #8","https://goo.gl/Zcm4r6",2),
            new Videos(9,"¿Cómo crear un filtro avanzado en una Base de Datos en Excel? | Gestión de la Información #9","https://goo.gl/z6Nzwu",2),
            new Videos(10,"Aprende a validar datos en Excel | Gestión de la Información #10","https://goo.gl/JyMCeE",2),
            new Videos(11,"¿Cómo crear Tablas Dinámicas en Excel? | Gestión de la Información #11","https://goo.gl/2npG6Y",3),
            new Videos(12,"Agrupar campos en Tablas Dinámicas en Excel | Gestión de la Información #12","https://goo.gl/SKGwGt",3),
            new Videos(13,"Mostrar datos como porcentaje de fila o columna | Gestión de la Información #13","https://goo.gl/urrrP5",3),
            new Videos(14,"Segmentación de Datos en Tablas Dinámicas en Excel | Gestión de la Información #14","https://goo.gl/e5NfSt",3),
            new Videos(15,"Combinando correspondencia con Word y una base de datos en Excel | Gestión de la Información #15","https://goo.gl/LPM51S",4),
            new Videos(16,"Formato condicional en Excel Parte 1 | Gestión de la Información #16","https://goo.gl/fxXnqo",4),
            new Videos(17,"Formato condicional en Excel Parte 2 | Gestión de la Información #17","https://goo.gl/1ybnkZ",4),
            new Videos(18,"Formato condicional en Excel Parte 3 | Gestión de la Información #18","https://goo.gl/HVRNvA",4),
            new Videos(19,"¿Cómo generar minigráficos en Excel? | Gestión de la Información #19","https://goo.gl/wZB4VD",4),
            new Videos(20,"Cinta y barra de menú rápida en Excel | Gestión de la Información #20","https://goo.gl/pj8wua",4),
            new Videos(21,"Conoce todos los menús en la presentación de excel | Gestión de la Información #21","https://goo.gl/FtMcTZ",4),
            new Videos(22,"Conoce todas las opciones de menú en Excel | Gestión de la Información #22","https://goo.gl/XxTo2b",4),
            new Videos(23,"¿Cómo hacer consultas web desde Excel y generar Bases de Datos? | Gestión de la Información #23","https://goo.gl/XnXS9W",4),
            new Videos(24,"Creación de Macros en Excel | Gestión de la Información #24","https://goo.gl/NhNsT3",4)

        };

        public static List<Datos> Dato = new List<Datos>()
        {
            new Datos(1,"No usa una base de datos como ejemplo","N/A",1),
            new Datos(2,"No 1 EJEMPLO BD","https://www.poli.edu.co/sites/default/files/basesdatos/No-1-EJEMPLO-BD.XLS",2),
            new Datos(3,"EJEMPLO_BANCOS","https://www.poli.edu.co/sites/default/files/basesdatos/EJEMPLO_BANCOS.XLSX",3),
            new Datos(4,"No 3 NO BD","https://www.poli.edu.co/sites/default/files/basesdatos/No-3-NO-BD.XLS",4),
            new Datos(5,"BD_VENTAS","https://www.poli.edu.co/sites/default/files/basesdatos/BD_VENTAS.XLSX",5),
            new Datos(6,"BD_VENTAS","https://www.poli.edu.co/sites/default/files/basesdatos/BD_VENTAS.XLSX",6),
            new Datos(7,"BD_VENTAS","https://www.poli.edu.co/sites/default/files/basesdatos/BD_VENTAS.XLSX",7),
            new Datos(8,"BD_VENTAS","https://www.poli.edu.co/sites/default/files/basesdatos/BD_VENTAS.XLSX",8),
            new Datos(9,"BD_VENTAS","https://www.poli.edu.co/sites/default/files/basesdatos/BD_VENTAS.XLSX",9),
            new Datos(10,"BD_VENTAS","https://www.poli.edu.co/sites/default/files/basesdatos/BD_VENTAS.XLSX",10),
            new Datos(11,"BD_VENTAS","https://www.poli.edu.co/sites/default/files/basesdatos/BD_VENTAS.XLSX",11),
            new Datos(12,"BD_VENTAS","https://www.poli.edu.co/sites/default/files/basesdatos/BD_VENTAS.XLSX",12),
            new Datos(13,"BD_VENTAS","https://www.poli.edu.co/sites/default/files/basesdatos/BD_VENTAS.XLSX",13),
            new Datos(14,"BD_VENTAS","https://www.poli.edu.co/sites/default/files/basesdatos/BD_VENTAS.XLSX",14),
            new Datos(15,"No 4.5 TABLA DINAMICA BD PERSONAL","http://comunicaciones.poligran.edu.co/documentacion/No4-5-TABLA-DINAMICA-BD-PERSONAL.xlsm",15),
            new Datos(16,"BD_VENTAS","https://www.poli.edu.co/sites/default/files/basesdatos/BD_VENTAS.XLSX",16),
            new Datos(17,"BD_VENTAS","https://www.poli.edu.co/sites/default/files/basesdatos/BD_VENTAS.XLSX",17),
            new Datos(18,"BD_VENTAS","https://www.poli.edu.co/sites/default/files/basesdatos/BD_VENTAS.XLSX",18),
            new Datos(19,"BD_VENTAS","https://www.poli.edu.co/sites/default/files/basesdatos/BD_VENTAS.XLSX",19),
            new Datos(20,"Libro limpio Excel","N/A",20),
            new Datos(21,"Libro limpio Excel & BD_VENTAS","https://www.poli.edu.co/sites/default/files/basesdatos/BD_VENTAS.XLSX",21),
            new Datos(22,"Libro limpio Excel","N/A",22),
            new Datos(23,"CONSULTA_WEB","https://www.poli.edu.co/sites/default/files/basesdatos/CONSULTA_WEB.XLSX",23),
            new Datos(24,"No 4.5 TABLA DINAMICA BD PERSONAL","http://comunicaciones.poligran.edu.co/documentacion/No4-5-TABLA-DINAMICA-BD-PERSONAL.xlsm",24)

        };
            

        public class Modulos
        {
            //Definir campos
            int idModulo;
            string nombre_Modulo;

            public Modulos(int idModulo, string nombre_Modulo)
            {
                this.IdModulo = idModulo;
                this.Nombre_Modulo = nombre_Modulo;
            }

            public int IdModulo { get => idModulo; set => idModulo = value; }
            public string Nombre_Modulo { get => nombre_Modulo; set => nombre_Modulo = value; }
        }
        public class Videos
        {
            int idVideo;
            string nombre_Video;
            string url_Video;
            int idModulo;

            public Videos(int idVideo, string nombre_Video, string url_Video, int idModulo)
            {
                this.IdVideo = idVideo;
                this.Nombre_Video = nombre_Video;
                this.Url_Video = url_Video;
                this.IdModulo = idModulo;
            }

            public int IdVideo { get => idVideo; set => idVideo = value; }
            public string Nombre_Video { get => nombre_Video; set => nombre_Video = value; }
            public string Url_Video { get => url_Video; set => url_Video = value; }
            public int IdModulo { get => idModulo; set => idModulo = value; }
        }

        public class Datos
        {
            int idDato;
            string nombre_Datos;
            string url_Datos;
            int idVideo;

            public Datos(int idDato, string nombre_Datos, string url_Datos, int idVideo)
            {
                this.IdDato = idDato;
                this.Nombre_Datos = nombre_Datos;
                this.Url_Datos = url_Datos;
                this.IdVideo = idVideo;
            }

            public int IdDato { get => idDato; set => idDato = value; }
            public string Nombre_Datos { get => nombre_Datos; set => nombre_Datos = value; }
            public string Url_Datos { get => url_Datos; set => url_Datos = value; }
            public int IdVideo { get => idVideo; set => idVideo = value; }
        }

    }
}
