using System.Net.Mime;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Http
{
    public static class HttpResponseExtensions
    {
        public static async Task InternalServerErrorAsJsonAsync<TContent>(this HttpResponse response, TContent content, CancellationToken cancellationToken)
        {
            response.StatusCode = StatusCodes.Status500InternalServerError;
            await response.WriteAsJsonAsync(content, cancellationToken).ConfigureAwait(false);
        }

        public static async Task BadRequestAsJsonAsync<TContent>(this HttpResponse response, TContent content, CancellationToken cancellationToken)
        {
            response.StatusCode = StatusCodes.Status400BadRequest;
            await response.WriteAsJsonAsync(content, cancellationToken).ConfigureAwait(false);
        }

        public static async Task OkAsJsonAsync<TContent>(this HttpResponse response, TContent content, CancellationToken cancellationToken)
        {
            response.StatusCode = StatusCodes.Status200OK;
            await response.WriteAsJsonAsync(content, cancellationToken).ConfigureAwait(false);
        }

        public static async Task WriteAsJsonAsync<TContent>(this HttpResponse response, TContent content, CancellationToken cancellationToken)
        {
            response.ContentType = MediaTypeNames.Application.Json;
            await response.WriteAsync(JsonSerializer.Serialize(content), cancellationToken).ConfigureAwait(false);
        }
    }
}
