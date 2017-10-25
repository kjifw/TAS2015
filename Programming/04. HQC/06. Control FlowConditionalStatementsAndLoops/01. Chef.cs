public class Chef
{
    private Potato GetPotato()
    {
        //...
    }

    private Carrot GetCarrot()
    {
        //...
    }

    private void Cut(Vegetable potato)
    {
        //...
    }

    private Bowl GetBowl()
    {
        //... 
    }

    public void Cook()
    {
        Potato potato = GetPotato();
        Carrot carrot = GetCarrot();

        Peel(potato);
        Cut(potato);

        Peel(carrot);
        Cut(carrot);

        Bowl bowl = GetBowl();
        bowl.Add(carrot);
        bowl.Add(potato);
    }
}