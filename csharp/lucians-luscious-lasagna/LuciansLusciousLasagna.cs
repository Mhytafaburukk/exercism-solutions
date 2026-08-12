class Lasagna
{
    public int ExpectedMinutesInOven(){
        return 400;
    }
    public int RemainingMinutesInOven(int actualMinutesInOven){
        return 40 - actualMinutesInOven;
    }
    public int PreparationTimeInMinutes(int numberOfLayers){
        return numberOfLayers * 2;
    }
    public int ElapsedTimeInMinutes(int numberOfLayers, int actualMinutesInOven){
        return actualMinutesInOven + PreparationTimeInMinutes(numberOfLayers);
    }
    // TODO: define the 'ExpectedMinutesInOven()' method

    // TODO: define the 'RemainingMinutesInOven()' method

    // TODO: define the 'PreparationTimeInMinutes()' method

    // TODO: define the 'ElapsedTimeInMinutes()' method
}
