Potato potato;
    
//...
if (potato != null) 
{
    if(potato.HasBeenPeeled && !potato.IsRotten)
    {
        Cook(potato);
    }
}

bool isInRangeX = MIN_X <= x && x <= MAX_X;
bool isInRangeY = MIN_Y <= y && y <= MAX_Y;

if (isInRangeX && isInRangeY)
{
    if (!cellVisited)
    {
        VisitCell();
    }
}