using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    //Loading comic.
    public class ComicProcessor1
    {
        //buliding actual call of api
        public static async Task<ComicModel1> LoadComic(int comicNumber = 0)
        {
            string url = "";
            if (comicNumber>0)
            {
                url = $"https://xkcd.com/{ comicNumber}/info.0.json";
            }
            else
            {
                url= "https://xkcd.com/info.0.json";
            }
            using (HttpResponseMessage response= await APIHelper1.ApiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    ComicModel1 comic = await response.Content.ReadAsAsync<ComicModel1>();
                    return comic;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }

    }
}
