using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Discord.Commands;

namespace Bot.Modules
{
    public class DontAskToAskModule : ModuleBase
    {
        [Command("howtoask")]
        public async Task HowToAsk()
        {
            await ReplyAsync("Don't ask questions just to ask the question. E.G. \"Does anyone know about....\" should not be a question because we don't first want to answer yes but then not being able to answer it. JUST ASK THE QUESTION INSTEAD!!!!!");
        }

        [Command("HowToSendPicture")]
        public async Task HowToSendPicture()
        {
            await ReplyAsync(
                "We do not support sending the picture as a file outside the general chat, random, discussions and bots to prevent people from sharing other files which could potentially contain viruses. Instead, you could try to use igmur https://igmur.com OR just send it in #Bots , then copy the discordlink");
        }

        [Command("Help")]
        public async Task Help()
        {
            await ReplyAsync($"Prefix: ${Environment.NewLine}HowToAsk - explain to not ask to ask...{Environment.NewLine}HowToSendPicture - explain that we cant send pictures");
        }

        [Command("Politics")]
        public async Task Politics()
        {
            await ReplyAsync("You are allowed to talk politics in #general, but please accept everyone's view, except when it's extreme leftish or extreme right cos fock dat shit.");
        }

        [Command("Tikkie")]
        public async Task Tikkie()
        {
            await ReplyAsync("Vergeet niet die twee euro tikkie voor dat frikandelbroodje van gisteren he!");
        }
    }
}
