namespace chess_with_dislocations;

public class Pieces
{
    protected struct PieceInfo
    {
        public int Rank;
        public int File;
        // indicate team, true indicates white
        public bool Team;
        public char Type;
        public bool IsEmpty;
    }
    
    // store position of piece
    protected PieceInfo Info;
    protected Pieces()
    {
        Info.IsEmpty = true;
    }

    public char GetType()
    {
        return Info.Type;
    }

    public bool IsEmpty()
    {
        return Info.IsEmpty;
    }
}

public class Pawn : Pieces
{
    public Pawn(int rank, int file, bool team)
    {
        Info.Rank = rank;
        Info.File = file;
        Info.Team = team;
        Info.Type = 'p';
        Info.IsEmpty = false;
    }
}

public class Rook : Pieces
{
    public Rook(int rank, int file, bool team)
    {
        Info.Rank = rank;
        Info.File = file;
        Info.Team = team;
        Info.Type = 'r';
        Info.IsEmpty = false;
    }
}

public class Knight : Pieces
{
    public Knight(int rank, int file, bool team)
    {
        Info.Rank = rank;
        Info.File = file;
        Info.Team = team;
        Info.Type = 'k';
        Info.IsEmpty = false;
    }
}

public class Bishop : Pieces
{
    public Bishop(int rank, int file, bool team)
    {
        Info.Rank = rank;
        Info.File = file;
        Info.Team = team;
        Info.Type = 'b';
        Info.IsEmpty = false;
    }
}

public class Queen : Pieces
{
    public Queen(int rank, int file, bool team)
    {
        Info.Rank = rank;
        Info.File = file;
        Info.Team = team;
        Info.Type = 'q';
        Info.IsEmpty = false;
    }
}

public class King : Pieces
{
    public King(int rank, int file, bool team)
    {
        Info.Rank = rank;
        Info.File = file;
        Info.Team = team;
        Info.Type = 'K';
        Info.IsEmpty = false;
    }
}

public class OutOfBounds : Pieces
{
    public OutOfBounds(int rank, int file)
    {
        Info.Rank = rank;
        Info.File = file;
        Info.Type = '#';
        Info.IsEmpty = false;
    }
}

public class Empty : Pieces
{
    public Empty(int rank, int file)
    {
        Info.Rank = rank;
        Info.File = file;
        Info.Type = ' ';
        Info.IsEmpty = true;
    }
}