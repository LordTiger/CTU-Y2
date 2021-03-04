package Question2;

import javax.swing.JOptionPane;

public class Main
{

    private static boolean isValid(String a)
    {
        a = a.toLowerCase();
        if(a.equals("a") || a.equals("b") || a.equals("c"))
        {
            return true;
        }
        else
        {
            JOptionPane.showMessageDialog(null, "Choose A, B or C");
            return false;
        }
    }

    private static String askQuestion(String[] q)
    {
        String fmtQuestion = ""; // String to hold the formatted question
        String answer = "";

        for(int i = 0; i < q.length; i++)
            fmtQuestion += q[i] + "\n";

        do
        {
            answer = JOptionPane.showInputDialog(null, fmtQuestion);
            if(answer == null)
            {
                int quit = JOptionPane.showConfirmDialog(null, "Would you like to quit?", "Quit", JOptionPane.YES_NO_OPTION);
                if(quit == 0)
                    return "ABORT";
                else
                    continue;
            }
        } while (answer == null || !(isValid(answer)));

        return answer;
    }

    private static boolean isCorrect(String a, String r) // a = correct answer, r = user response
    {
        r = r.toUpperCase();
        if(a.equals(r))
        {
            JOptionPane.showMessageDialog(null, "Correct!");
            return true;
        }
        else
        {
            JOptionPane.showMessageDialog(null, "The correct answer is: \n" + a);
            return false;
        }
    }

    public static void showGrade(int c, int i)
    {
        int numberQuestions = c + i;
        String fmtGrade = "";
        int pointsPerQuestion = 100 / numberQuestions;
        int grade = c * pointsPerQuestion;

        fmtGrade += "You answered " + c + " correctly and " + i + " incorrectly";
        fmtGrade += "\nYour grade is: " + grade + "%";

        JOptionPane.showMessageDialog(null, fmtGrade);
    }

    public static void main(String[] args)
    {
        int i = 0;
        int correct = 0;
        int incorrect = 0;
        String response = "";


        String[][] question = new String[10][4];
        String[] correctAnswer = new String[10];

        question[0][0] = "Which one of the following is a terrible game?";
        question[0][1] = "A) Half-Life";
        question[0][2] = "B) Dark Souls";
        question[0][3] = "C) CS:G0";
        correctAnswer[0] = "C";

        question[1][0] = "What is the best operating system?";
        question[1][1] = "A) MAC OS";
        question[1][2] = "B) Linux";
        question[1][3] = "C) Windows";
        correctAnswer[1] = "B";

        question[2][0] = "Which of the following is the oldest programming language? ";
        question[2][1] = "A) ALGOL 58";
        question[2][2] = "B) COBOL";
        question[2][3] = "C) FORTRAN";
        correctAnswer[2] = "C";

        question[3][0] = "Which is worst?";
        question[3][1] = "A) Fortnite";
        question[3][2] = "B) PUBG";
        question[3][3] = "C) All of the above";
        correctAnswer[3] = "C";

        question[4][0] = "Linux is best";
        question[4][1] = "A) Yes";
        question[4][2] = "B) No";
        question[4][3] = "C) Not at all";
        correctAnswer[4] = "A";

        question[5][0] = "Which one of the following is a terrible game?";
        question[5][1] = "A) Alien: Isolation";
        question[5][2] = "B) Far Cry 3";
        question[5][3] = "C) Cyberpunk 2077";
        correctAnswer[5] = "C";

        question[6][0] = "Which one of the following is a terrible game?";
        question[6][1] = "A) Dota 2";
        question[6][2] = "B) Hades";
        question[6][3] = "C) Bioshock";
        correctAnswer[6] = "A";

        question[7][0] = "Which one of the following is a terrible game?";
        question[7][1] = "A) Portal";
        question[7][2] = "B) Warframe";
        question[7][3] = "C) Doom";
        correctAnswer[7] = "B";

        question[8][0] = "Which game is the oldest?";
        question[8][1] = "A) Deus Ex";
        question[8][2] = "B) Half-Life";
        question[8][3] = "C) Age of Empires";
        correctAnswer[8] = "C";

        question[9][0] = "Best Game of 2020?";
        question[9][1] = "A) Control: Ultimate Edition";
        question[9][2] = "B) Half-Life: Alyx";
        question[9][3] = "C) Doom: Eternal";
        correctAnswer[9] = "B";

        do
        {
            response = askQuestion(question[i]);
            if(response.equals("ABORT"))
                return;
            if(isCorrect(correctAnswer[i], response))
                correct += 1;
            else
                incorrect += 1;

            i++;
        } while(i < question.length);

        showGrade(correct, incorrect);
    }
}
