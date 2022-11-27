namespace chess_with_dislocations;

public class Pieces
{
    protected struct Position
    {
        public int Rank;
        public int File;
        // indicate team, true indicates white
        public bool Team;
    }
    
    // store position of piece
    protected Position Pos;
    

    protected Pieces()
    {
        //
    }
}

public class Pawn : Pieces
{
    public Pawn(int rank, int file, bool team)
    {
        Pos.Rank = rank;
        Pos.File = file;
        Pos.Team = team;
    }
}

public class Rook : Pieces
{
    public Rook(int rank, int file, bool team)
    {
        Pos.Rank = rank;
        Pos.File = file;
        Pos.Team = team;
    }
}

public class Knight : Pieces
{
    public Knight(int rank, int file, bool team)
    {
        Pos.Rank = rank;
        Pos.File = file;
        Pos.Team = team;
    }
}

public class Bishop : Pieces
{
    public Bishop(int rank, int file, bool team)
    {
        Pos.Rank = rank;
        Pos.File = file;
        Pos.Team = team;
    }
}

public class Queen : Pieces
{
    public Queen(int rank, int file, bool team)
    {
        Pos.Rank = rank;
        Pos.File = file;
        Pos.Team = team;
    }
}

public class King : Pieces
{
    public King(int rank, int file, bool team)
    {
        Pos.Rank = rank;
        Pos.File = file;
        Pos.Team = team;
    }
}

public class OutOfBounds : Pieces
{
    public OutOfBounds(int rank, int file)
    {
        Pos.Rank = rank;
        Pos.File = file;
    }
}