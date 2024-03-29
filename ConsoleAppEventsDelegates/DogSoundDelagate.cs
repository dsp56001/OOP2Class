﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using DogLibrary;

namespace ConsoleAppEventsDelegates
{
    class DogSoundDelagate : Dog
    {
        SoundPlayer player;
        
        public DogSoundDelagate()
        {
            player = new SoundPlayer(@".\assets\bark.wav");
            player.LoadCompleted += this.Player_LoadCompleted;
        }

        public delegate string Barked(string Bark);

        public override string Bark()
        {
            player.PlaySync();
            return base.Bark();
        }

        public override string Bark(int HowManyTimes)
        {
            string barkstring = string.Empty;
            for (int i = 0; i < HowManyTimes; i++)
            {
                barkstring += this.Bark() + " ";
            }
            return barkstring.Trim(); //trim cleans off any trailing spaces.
            
        }

        private void loadSoundAsync()
        {
            //When the player is ready load the sound
            this.player.SoundLocation = @".\assets\bark.wav";
            this.player.LoadAsync();
        }

        private void Player_LoadCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            if (this.player.IsLoadCompleted)
            {
                this.player.PlaySync();
            }
        }

        public string BarkAsync(Barked callback)
        {
            this.loadSoundAsync();
            return callback(base.Bark()); 
        }

        
    }
}
