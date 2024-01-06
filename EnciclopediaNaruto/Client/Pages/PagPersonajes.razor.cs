using EnciclopediaNaruto.Shared;
using System.Net.Http.Json;
using System.Text.Json;
using System.Xml;

namespace EnciclopediaNaruto.Client.Pages
{
    public partial class PagPersonajes
    {
        List<Personaje> personajes = new List<Personaje>();
        protected override async Task OnInitializedAsync()
        {
            var uri = new Uri("https://narutodb.xyz/api/");
            var http = new HttpClient() { BaseAddress = uri};
            var request = await http.GetFromJsonAsync<Page>("character");
            personajes = request.characters;
            Console.WriteLine(request.characters.Count());
            //var responseContent = await request.Content.ReadAsStringAsync();

            // Deserializar la cadena JSON en un objeto C#
            //var jsonResponse = JsonSerializer.Deserialize<object>(responseContent);
            //var h = (List<Personaje>)GetPropValue(jsonResponse, "characters");
            //foreach (var personaje in h)
            //{
            //    Console.WriteLine(personaje.name);
            //}
            // Imprimir el objeto deserializado en la consola
            //Console.WriteLine(JsonSerializer.Serialize(jsonResponse, new JsonSerializerOptions { WriteIndented = true }));
        }
        public object GetPropValue(object src, string propName)
        {
            return src.GetType().GetProperty(propName).GetValue(src, null);
        }
    }
}
