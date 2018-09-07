using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Builder.Luis;
using Microsoft.Bot.Builder.Luis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace MiBotApp.Dialogs
{
    [LuisModel(modelID: "9bf0cecd-aa3a-4095-945c-80fb3b56fa6d",subscriptionKey: "51a8f6001cd94de38538aa5ab75fe5d8")]
    [Serializable]
    public class ServicioDeDialogo:LuisDialog<string>
    {
        [LuisIntent("None")]
        public async Task None(IDialogContext context, LuisResult result)
        {
            await context.PostAsync("Lo siento no puedo ayudarte");
            await context.PostAsync("puedes preguntarme otra cosa");
        }

        
             [LuisIntent("Despedida")]
        public async Task Despedida(IDialogContext context, LuisResult result)
        {
            await context.PostAsync("espero haberte ayudado");
            await context.PostAsync("te espero pronto");
        }

                    [LuisIntent("Saludo inicial")]
        public async Task Saludoinicial(IDialogContext context, LuisResult result)
        {
            await context.PostAsync("Hola como estas? ");
            await context.PostAsync("en que te puedo ayudar");
        }
    }
}