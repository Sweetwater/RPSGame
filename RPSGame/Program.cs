﻿using System;
using System.Collections.Generic;

namespace RPS
{
    /// <summary>
    /// ソース改変歴
    /// 初期: http://gist.github.com/491967
    /// まどがい先生後: http://gist.github.com/492045
    /// まいんちゃん後: http://github.com/Sweetwater/RPSGame
    /// </summary>
    class RPSGame
    {
        static void Main()
        {
            Console.Clear();
            var textSelector = new TextSelector() {
                Caption = "Choose Rule !!",
                Items = MatchFactory.RuleLists,
            };
            textSelector.Select();
            var selectedText = textSelector.SelectedText;
            var selectedNumber = textSelector.SelectedNumber;

            var match = MatchFactory.Create(selectedText, 3);

            for (int i = 0; i < 10; i++)
            {
                Console.Clear();

                match.Duel();

                Console.WriteLine();
                Console.WriteLine("Press any key...");
                Console.ReadKey();
            }
        }
    }
}