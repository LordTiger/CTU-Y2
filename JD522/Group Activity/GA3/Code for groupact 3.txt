package group3;
import javax.swing.*;
abstract class staff{
        private int staff_number,hours_worked;
        private String staff_descrption;
        float payment,totalPayment,rate;
        public float getPayment() {
                return payment;
        }
        public void setPayment(float payment) {
                this.payment = payment;
        }
        public float getTotalPayment() {
                return totalPayment;
        }
        public void setTotalPayment(float totalPayment) {
                this.totalPayment = totalPayment;
        }
        public int getStaff_number() {
                return staff_number;
        }
        public void setStaff_number(int staff_number) {
                this.staff_number = staff_number;
        }
        public float getRate() {
                return rate;
        }
        public void setRate(float rate) {
                this.rate = rate;
        }
        public int getHours_worked() {
                return hours_worked;
        }
        public void setHours_worked(int hours_worked) {
                this.hours_worked = hours_worked;
        }
        public String getStaff_descrption() {
                return staff_descrption;
        }
        public void setStaff_descrption(String staff_descrption) {
                this.staff_descrption = staff_descrption;
        }
        abstract void monthlyPayment();
        abstract void description();
        
}
final class staffInfos extends staff{
        staffInfos(){
                JFrame frame=new JFrame();
                frame.setLayout(null);
                frame.setSize(400,400);
                frame.setVisible(true);
                int  hours_worked;
                int id=Integer.parseInt(JOptionPane.showInputDialog(frame,"Enter Staff Number")); 
                String des= JOptionPane.showInputDialog(frame,"Enter Staff Description");
                float rate=Integer.parseInt(JOptionPane.showInputDialog(frame,"Enter Staff rate"));
                hours_worked=Integer.parseInt(JOptionPane.showInputDialog(frame,"Enter Staff Hours_worked")); 
                if (hours_worked>200) {
                        JOptionPane.showMessageDialog(frame, "ErrorMsg", "Failure", JOptionPane.ERROR_MESSAGE);
                        hours_worked=Integer.parseInt(JOptionPane.showInputDialog(frame,"Enter Staff Hours_worked")); 
                }
                setRate(rate);
                setHours_worked(hours_worked);
                setStaff_descrption(des);
                setStaff_number(id);
                int d=getStaff_number();
                monthlyPayment();
                System.out.print("Hello"+getPayment());
                description();
                System.out.println("Hello1"+getTotalPayment());

        }
        @Override
        public void monthlyPayment() {
                int p=50;
                float payment=(float)getHours_worked()*p;
                setPayment(payment);
        }

        @Override
        public void description() {
                if(getStaff_descrption().equalsIgnoreCase("Cleaner")) {
                        float total=(float) (getPayment()*0.14);
                        float total1=getPayment()-total;
                        setTotalPayment(total1);
                }else if(getStaff_descrption().equalsIgnoreCase("Lecturer")) {
                        float total=(float) (getPayment()*0.20);
                        float total1=getPayment()-total;
                        setTotalPayment(total1);
                        
                }else if(getStaff_descrption().equalsIgnoreCase("Admin")) {
                        float total=(float) (getPayment()*0.17);
                        float total1=getPayment()-total;
                        setTotalPayment(total1);
                }
        }
        
}

public class staffSalary {
        public static void main(String[] args) {
            staffInfos staffInfos = new staffInfos();
        }

}
