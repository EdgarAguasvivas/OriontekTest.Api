using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OriontekTest.Business.Exceptions
{
    public struct ErrorMessages
    {
        public static readonly string UnknownException = "Ha ocurrido un error inesperado.";
        public static readonly string SecurityException = "Acceso no autorizado.";
        public static readonly string ArgumentException = "Error en parámetros recibidos.";
        public static readonly string ArgumentNullException = "Parametros recibidos sin valor.";
        public static readonly string NotFoundExection = "Dato no encontrardo en la Base de Datos.";
        public static readonly string ProfileNotFoundException = "Error obteniendo información de perfil, sesion no valida.";
        public static readonly string UriFormatException = "Formato de ruta inválido.";
        public static readonly string HttpRequestException = "Error de comunicación.";
        public static readonly string EntityValidationException = "Error de Validación en la Entidad.";
        public static readonly string AuthorizationValidationException = "Error de Validación de Authorización.";
        public static readonly string EmptyCollections = "No se encontraron registros para mostrar o procesar!";
        public static readonly string ErrorCreating = "Se ha producido un error en la creación del registro!";
        public static readonly string ErrorUpdating = "Se ha producido un error en la actualización del registro!";
        public static readonly string ErrorDeleting = "Se ha producido un error al eliminar el registro!";
        public static readonly string RecordExist = "Ya existe un registro con estos Datos!";
        public static readonly string AuthorizationException = "El usuario no tiene acceso al sistema!";
        public static readonly string TokenAuthorizationException = "El usuario no ha iniciado sesión o hay errores en el token!";
        public static readonly string LoginFailedException = "Usuario o contraseña incorrecto";
        public static readonly string NotExistInvoice = "Esta factura no existe";
        public static readonly string NullParam = "Parametros vacios";
    }
}
