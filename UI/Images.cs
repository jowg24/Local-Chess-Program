using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using Logic;

namespace UserInterface
{
    public static class Images
    {
        private static readonly Dictionary<PieceType, ImageSource> whiteSources = new()
        {
            { PieceType.Pawn, LoadImage("Board Assets/PawnW.png") },
            { PieceType.Bishop, LoadImage("Board Assets/BishopW.png") },
            { PieceType.Knight, LoadImage("Board Assets/KnightW.png") },
            { PieceType.Rook, LoadImage("Board Assets/RookW.png") },
            { PieceType.Queen, LoadImage("Board Assets/QueenW.png") },
            { PieceType.King, LoadImage("Board Assets/KingW.png") }
        };

        private static readonly Dictionary<PieceType, ImageSource> blackSources = new()
        {
            { PieceType.Pawn, LoadImage("Board Assets/PawnB.png") },
            { PieceType.Bishop, LoadImage("Board Assets/BishopB.png") },
            { PieceType.Knight, LoadImage("Board Assets/KnightB.png") },
            { PieceType.Rook, LoadImage("Board Assets/RookB.png") },
            { PieceType.Queen, LoadImage("Board Assets/QueenB.png") },
            { PieceType.King, LoadImage("Board Assets/KingB.png") }
        };
        public static ImageSource LoadImage(string filePath)
        {
            return new BitmapImage(new Uri(filePath, UriKind.Relative));
        }

        public static ImageSource GetImage(Player colour, PieceType type)
        {
            return colour switch
            {
                Player.White => whiteSources[type],
                Player.Black => blackSources[type],
                _ => null
            };
        }

        public static ImageSource GetImage(Piece piece)
        {
            if (piece == null)
            {
                return null;
            }
            
            return GetImage(piece.Colour, piece.Type);
        }
    }

}
