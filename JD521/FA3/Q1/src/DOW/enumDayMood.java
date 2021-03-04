package DOW;
// Brandon de Bruyn 6854
// FA3 Q1 enumDayMood Class
import javax.swing.*;

public class enumDayMood {
    Day day;

    public enumDayMood(Day day) {
        this.day = day;
    }

    public void telDayMood() {
        switch (day) {
            case MONDAY:
                JOptionPane.showMessageDialog(null, "Mondays are bad.");
                break;
            case FRIDAY:
                JOptionPane.showMessageDialog(null, "Fridays are Better.");
                break;
            case SATURDAY:
                JOptionPane.showMessageDialog(null, "Weekends are best.");
                break;
            default:
                JOptionPane.showMessageDialog(null, "Midweek days are so-so.");
                break;
        }
    }

    public void userInput() {
        String input = JOptionPane.showInputDialog(null,  "What day is it today");
        switch (input) {
            case "Monday":
                enumDayMood moDay = new enumDayMood(Day.MONDAY);
                moDay.telDayMood();
                break;
            case "Tuesday":
                enumDayMood tuDay = new enumDayMood(Day.TUESDAY);
                tuDay.telDayMood();
                break;
            case "Wednesday":
                enumDayMood weDay = new enumDayMood(Day.WEDNESDAY);
                weDay.telDayMood();
                break;
            case "Thursday":
                enumDayMood thDay = new enumDayMood(Day.THURSDAY);
                thDay.telDayMood();
                break;
            case "Friday":
                enumDayMood frDay = new enumDayMood(Day.FRIDAY);
                frDay.telDayMood();
                break;
            case "Saturday":
                enumDayMood saDay = new enumDayMood(Day.SATURDAY);
                saDay.telDayMood();
                break;
            case "Sunday":
                enumDayMood suDay = new enumDayMood(Day.SUNDAY);
                suDay.telDayMood();
                break;
            default:
                JOptionPane.showMessageDialog(null, 0);
                break;

        }
    }
}
