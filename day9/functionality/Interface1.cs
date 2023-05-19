 ﻿using Day_9.Models;
using System;
using System.Collections.Generic;


namespace Day_9.Functionality
    {
        public interface IFootballListMethod
        {
            int CreatePlayer(Player player);

            List<Player> GetPlayers();
            void UpdatePlayer(int id);
            void SearchPlayer(int id);
            void RemovePlayer(int id);
        }
    }


