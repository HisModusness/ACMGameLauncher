﻿using System.IO;
using Newtonsoft.Json.Linq;

namespace ACMLauncher.GameLibrary
{
    public class Game
    {
        public string PathToGameFolder { get; set; }
        public FileInfo Executable { get; set; }
        public string GameName { get; set; }

        //TODO: Change this based on what we require the game to come with, so we can display summary information and link to an image 
        public JArray InializerFile { get; set; }
    }
}