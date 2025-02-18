﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace UserInterface
{
    public static class ChessCursors
    {

        public static readonly Cursor WhiteCursor = LoadCursor("Board Assets/CursorW.cur");
        public static readonly Cursor BlackCursor = LoadCursor("Board Assets/CursorB.cur");
        private static Cursor LoadCursor(string filePath)
        {
            Stream stream = Application.GetResourceStream(new Uri(filePath, UriKind.Relative)).Stream;
            return new Cursor(stream, true);
        }
    }
}
