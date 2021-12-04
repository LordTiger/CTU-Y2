package fa3;
import java.io.BufferedReader;
import java.io.FileReader;
import java.io.IOException;
import java.util.ArrayList;
import java.util.logging.Level;
import java.util.logging.Logger;
import java.sql.*;
import javax.swing.JOptionPane;

/*
* To change this license header, choose License Headers in Project Properties.
* To change this template file, choose Tools | Templates
* and open the template in the editor.
*/
/**
*
* @author Brandon
*/
public class studentResult extends javax.swing.JFrame {

/**
* Creates new form studentResult
*/
String line1;
String line2;
String line3;
String formatMax;
String formatMin;
String formatAvg;
float num1;
float num2;
float num3;

public studentResult() {
initComponents();
}

/**
* This method is called from within the constructor to initialize the form.
* WARNING: Do NOT modify this code. The content of this method is always
* regenerated by the Form Editor.
*/
@SuppressWarnings("unchecked")
// <editor-fold defaultstate="collapsed" desc="Generated Code">
private void initComponents() {

jScrollPane1 = new javax.swing.JScrollPane();
studentListBox = new javax.swing.JList<>();
avgResult = new javax.swing.JLabel();
highResult = new javax.swing.JLabel();
lowResult = new javax.swing.JLabel();
searchBtn = new javax.swing.JButton();
saveBtn = new javax.swing.JButton();
jLabel1 = new javax.swing.JLabel();
jLabel2 = new javax.swing.JLabel();
jLabel3 = new javax.swing.JLabel();

setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);

studentListBox.setModel(new javax.swing.AbstractListModel<String>() {
String[] strings = { "10111", "10112", "10113" };
public int getSize() { return strings.length; }
public String getElementAt(int i) { return strings[i]; }
});
jScrollPane1.setViewportView(studentListBox);

avgResult.setText(" ");

highResult.setText(" ");

lowResult.setText(" ");

searchBtn.setText("Search");
searchBtn.addActionListener(new java.awt.event.ActionListener() {
public void actionPerformed(java.awt.event.ActionEvent evt) {
searchBtnActionPerformed(evt);
}
});

saveBtn.setText("Save");
saveBtn.addActionListener(new java.awt.event.ActionListener() {
public void actionPerformed(java.awt.event.ActionEvent evt) {
saveBtnActionPerformed(evt);
}
});

jLabel1.setText("Average Result:");

jLabel2.setText("Highest Result:");

jLabel3.setText("Lowest Result:");

javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
getContentPane().setLayout(layout);
layout.setHorizontalGroup(
layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
.addGroup(layout.createSequentialGroup()
.addContainerGap()
.addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
.addGroup(layout.createSequentialGroup()
.addComponent(jScrollPane1, javax.swing.GroupLayout.PREFERRED_SIZE, 148, javax.swing.GroupLayout.PREFERRED_SIZE)
.addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
.addGroup(layout.createSequentialGroup()
.addGap(24, 24, 24)
.addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING)
.addComponent(jLabel2)
.addComponent(jLabel3)))
.addGroup(layout.createSequentialGroup()
.addGap(18, 18, 18)
.addComponent(jLabel1)))
.addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, 100, Short.MAX_VALUE)
.addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
.addComponent(highResult)
.addComponent(avgResult)
.addComponent(lowResult)))
.addGroup(layout.createSequentialGroup()
.addComponent(searchBtn)
.addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
.addComponent(saveBtn)))
.addGap(40, 40, 40))
);
layout.setVerticalGroup(
layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
.addGroup(layout.createSequentialGroup()
.addContainerGap()
.addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
.addGroup(layout.createSequentialGroup()
.addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
.addComponent(avgResult)
.addComponent(jLabel1))
.addGap(26, 26, 26)
.addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
.addComponent(jLabel2)
.addComponent(highResult))
.addGap(25, 25, 25)
.addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
.addComponent(lowResult)
.addComponent(jLabel3)))
.addComponent(jScrollPane1, javax.swing.GroupLayout.PREFERRED_SIZE, 161, javax.swing.GroupLayout.PREFERRED_SIZE))
.addGap(49, 49, 49)
.addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
.addComponent(searchBtn)
.addComponent(saveBtn))
.addContainerGap(32, Short.MAX_VALUE))
);

pack();
}// </editor-fold>

private void searchBtnActionPerformed(java.awt.event.ActionEvent evt) {
    try {
        readFile();
    } catch (IOException ex) {
    Logger.getLogger(studentResult.class.getName()).log(Level.SEVERE, null, ex);
    }
}

private void saveBtnActionPerformed(java.awt.event.ActionEvent evt) {
    try {
        saveStudent();
    } catch (SQLException ex) {
        Logger.getLogger(studentResult.class.getName()).log(Level.SEVERE, null, ex);
    } catch (ClassNotFoundException ex) {
        Logger.getLogger(studentResult.class.getName()).log(Level.SEVERE, null, ex);
    }
}

/**
* @param args the command line arguments
*/
public static void main(String args[]) {
/* Set the Nimbus look and feel */
//<editor-fold defaultstate="collapsed" desc=" Look and feel setting code (optional) ">
/* If Nimbus (introduced in Java SE 6) is not available, stay with the default look and feel.
* For details see http://download.oracle.com/javase/tutorial/uiswing/lookandfeel/plaf.html
*/
try {
for (javax.swing.UIManager.LookAndFeelInfo info : javax.swing.UIManager.getInstalledLookAndFeels()) {
if ("Nimbus".equals(info.getName())) {
javax.swing.UIManager.setLookAndFeel(info.getClassName());
break;
}
}
} catch (ClassNotFoundException ex) {
java.util.logging.Logger.getLogger(studentResult.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
} catch (InstantiationException ex) {
java.util.logging.Logger.getLogger(studentResult.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
} catch (IllegalAccessException ex) {
java.util.logging.Logger.getLogger(studentResult.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
} catch (javax.swing.UnsupportedLookAndFeelException ex) {
java.util.logging.Logger.getLogger(studentResult.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
}
//</editor-fold>

/* Create and display the form */
java.awt.EventQueue.invokeLater(new Runnable() {
public void run() {
new studentResult().setVisible(true);
}
});
}

// File is read in this method
public void readFile() throws IOException {
    int i = 0;
    try (BufferedReader Reader = new BufferedReader(new FileReader("students.txt"))) {
        ArrayList<String> ArrayList = new ArrayList<>();
        String Line = Reader.readLine();
        while (Line != null) {
            if (getListValue().equals(Line)) {
                while (Line != null && i != 4) {
                    ArrayList.add(Line);

                    switch (i) {
                        case 1:
                            line1 = Line;
                            num1 = Float.parseFloat(line1);
                            break;
                        case 2:
                            line2 = Line;
                            num2 = Float.parseFloat(line2);
                            break;
                        case 3:
                            line3 = Line;
                            num3 = Float.parseFloat(line3);
                            break;
                        default:
                            break;
                    }

                    float max = Math.max(Math.max(num1, num2), num3);
                    float min = Math.min(Math.min(num1, num2), num3);
                    float avg = (num1 + num2 + num3) / 3;

                    formatMax = String.format("%.02f", max);
                    formatMin = String.format("%.02f", min);
                    formatAvg = String.format("%.02f", avg);

                    Line = Reader.readLine();
                    i++;

                    avgResult.setText(formatAvg);
                    highResult.setText(formatMax);
                    lowResult.setText(formatMin);
                }   
            } else {
                Line = Reader.readLine();
            }
        }
    }
}



public void saveStudent() throws SQLException, ClassNotFoundException {
    try {
        // Connection created here. ConnectinString also added here so the user can connect.
        Class.forName("com.mysql.cj.jdbc.Driver");
        Connection con = DriverManager.getConnection("jdbc:mysql://localhost:3306/studentresult", "root", "TigerKiller_1");
        Statement stm = con.createStatement();
        String studentID;
        studentID = studentListBox.getSelectedValue();

        // Student's number, their highest result, their lowest result and average result is inserted to database.
        String insert = "INSERT INTO resulttable (studentNumber, highestResult, lowestResult, average) VALUES ("+studentID+", "+highResult.getText()+", "+lowResult.getText()+", "+avgResult.getText()+")";
        //Inputting data to database 
        stm.execute(insert);
        // Update is executed.
        JOptionPane.showMessageDialog(this, "Data Saved Succesfully");
        con.close();

    // Exception is caught here
    } catch (Exception e) {
        JOptionPane.showMessageDialog(null, e);
    }
}

// Value inside of the listbox is retrieved and used
public String getListValue() {
String listName;
listName = studentListBox.getSelectedValue();
return listName;
}


// Variables declaration - do not modify
private javax.swing.JLabel avgResult;
private javax.swing.JLabel highResult;
private javax.swing.JLabel jLabel1;
private javax.swing.JLabel jLabel2;
private javax.swing.JLabel jLabel3;
private javax.swing.JScrollPane jScrollPane1;
private javax.swing.JLabel lowResult;
private javax.swing.JButton saveBtn;
private javax.swing.JButton searchBtn;
private javax.swing.JList<String> studentListBox;
// End of variables declaration
}