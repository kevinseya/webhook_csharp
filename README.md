# Proyecto Webhook en C# con ASP.NET Core

Este proyecto implementa un **webhook** sencillo utilizando **ASP.NET Core API**. Al iniciar la aplicación, se despliega automáticamente una interfaz Swagger para probar el endpoint del webhook.

## Estructura del Proyecto

- **`WebhookController`**: Controlador que maneja las solicitudes POST recibidas en el endpoint del webhook.

## Requisitos

- **.NET SDK** 6.0 o superior.
- Herramienta de línea de comandos `dotnet` instalada.

## Ejecución del Proyecto

1. **Clona el repositorio** y navega al directorio del proyecto:

    ```bash
    git clone <https://github.com/kevinseya/webhook_csharp.git>
    ```

2. **Ejecuta el proyecto** con el siguiente comando:

    ```bash
    dotnet run
    ```

3. Una vez ejecutado, accede a la interfaz Swagger en:

    ```bash
    http://localhost:5000/swagger
    ```

## Uso del Webhook

### Endpoint

- **URL:** `/Webhook`
- **Método:** `POST`
- **Formato del Payload:** JSON

### Ejemplo de Payload

```json
{
  "data": "Ejemplo de datos para el webhook"
}
```
### Ejemplo de Respuesta
```json
{
  "message": "Webhook recibido exitosamente",
  "data": {
    "data": "Ejemplo de datos para el webhook"
  }
}
```
