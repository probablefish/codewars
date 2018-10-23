// Successful solution

import java.lang.*;

public class Spiders
{
    private static String[][] legs = {{"^", "^"}, {"/\\", "/\\"}, {"/╲", "╱\\"}, {"╱╲", "╱╲"}};
    private static String[][] bodies = {{"(", ")"}, {"((", "))"}, {"(((", ")))"}};


    public static String drawSpider(int legSize, int bodySize, char mouth, char eye) {
        int TotalNumberOfEyes = (int) Math.pow(2, bodySize);
        String spider = "";
        
        spider += legs[legSize - 1][0];
        spider += bodies[bodySize - 1][0];

        String eyes = getEyes(TotalNumberOfEyes / 2, eye);
        spider += eyes;
        spider += mouth;
        spider += eyes;

        spider += bodies[bodySize - 1][1];
        spider += legs[legSize - 1][1];

        return spider;
    }

    private static String getEyes(int numberOfEyes, char eyeType) {
        String eyes = "";
        for (int i = 0; i < numberOfEyes; i++){
             eyes += eyeType;
        }
        return eyes;
    }
}