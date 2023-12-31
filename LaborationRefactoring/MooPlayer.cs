﻿namespace LaborationRefactoring;

	internal class MooPlayer : IPlayer
	{
    public string PlayerName { get; set; }
    public int NumberOfRoundsPlayed { get; set; }
    int numberOfGuesses;


    public MooPlayer(string name, int guesses)
    {
        this.PlayerName = name;
        NumberOfRoundsPlayed = 1;
        numberOfGuesses = guesses;
    }

    public void Update(int guesses)
    {
        numberOfGuesses += guesses;
        NumberOfRoundsPlayed++;
    }

    public double Average()
    {
        return (double)numberOfGuesses / NumberOfRoundsPlayed;
    }


    public override bool Equals(Object p)
    {
        return PlayerName.Equals(((MooPlayer)p).PlayerName);
    }


    public override int GetHashCode()
    {
        return PlayerName.GetHashCode();
    }
}

	
