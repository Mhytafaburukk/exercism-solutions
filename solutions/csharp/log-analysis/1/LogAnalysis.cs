public static class LogAnalysis 
{
    public static String SubstringAfter(this String value,String obstacle){
        int index = value.IndexOf(obstacle);
        if(index==-1){
            return string.Empty;
        }
        return value.substring(index + obstacle.length());
    }

    public static String SubstringBetween(this String value,String firstObstacle,String secondObstacle){
        int first = value.IndexOf(firstObstacle);
        int last = secondObstacle-firstObstacle;
        return value.substring(first+1,last-1);
    }
    public static String Message(this String value){
        return $"{value.SubstringAfter(": ")}";
    }
    public static String LogLevel(){
        return $"{value.SubstringBetween("[","]")}";
    }

}