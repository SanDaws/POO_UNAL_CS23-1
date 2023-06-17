package Figuras;

import javax.swing.*;
import java.awt.*;
import java.awt.event.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

public class WindowPiramide extends JFrame implements ActionListener {
    private Container Layout;
    private JLabel TextoBase, TextoAltura, TextoApotema, TextoVolumen, TextoSuperficie;
    private JTextField InputBase, InputAltura, InputApotema;
    private JButton BotonCalcular;
    public WindowPiramide() {
        inicio();
        setTitle("Pirámide"); 
        setSize(280,240); 
        setLocationRelativeTo(null); 
        setResizable(false); 
    }
    
    private void inicio() {
        Layout = getContentPane(); 
        Layout.setLayout(null); 
        TextoBase = new JLabel();
        TextoBase.setText("Base [cm]:");
        TextoBase.setBounds(20, 20, 135, 23);
        InputBase = new JTextField();
        InputBase.setBounds(120, 20, 135, 23);
        TextoAltura = new JLabel();
        TextoAltura.setText("Altura [cm]:");
        TextoAltura.setBounds(20, 50, 135, 23);
        InputAltura = new JTextField();
        InputAltura.setBounds(120, 50, 135, 23);
        TextoApotema = new JLabel();
        TextoApotema.setText("Apotema [cm]:");
        TextoApotema.setBounds(20, 80, 135, 23);
        InputApotema = new JTextField();
        InputApotema.setBounds(120, 80, 135, 23);
        BotonCalcular = new JButton();
        BotonCalcular.setText("Calcula");
        BotonCalcular.setBounds(75, 110, 135, 23); 
        BotonCalcular.addActionListener(this);
        TextoVolumen = new JLabel();
        TextoVolumen.setText("Volumen [cm^3]:");
        TextoVolumen.setBounds(20, 140, 135, 23);
        TextoSuperficie = new JLabel();
        TextoSuperficie.setText("Superficie [cm^2]:");
        TextoSuperficie.setBounds(20, 170, 135, 23);
        Layout.add(TextoBase);
        Layout.add(InputBase);
        Layout.add(TextoAltura);
        Layout.add(InputAltura);
        Layout.add(TextoApotema);
        Layout.add(InputApotema);
        Layout.add(BotonCalcular);
        Layout.add(TextoVolumen);
        Layout.add(TextoSuperficie);
    }
    public void actionPerformed(ActionEvent event) {
        Piramide piramide;
        boolean error = false;
        double base = 0;
        double altura = 0;
        double apotema = 0;
        try {
            base = Double.parseDouble(InputBase.getText());
            altura = Double.parseDouble(InputAltura.getText());
            apotema = Double.parseDouble(InputApotema.getText());
            piramide = new Piramide(base, altura, apotema);
            TextoVolumen.setText("Volumen [cm^3]: " + String.format("%.2f",piramide.VolumenPiramide()));
            TextoSuperficie.setText("Superficie [cm^2]: " + String.format("%.2f",piramide.SuperficiePiramide()));
        } 
        catch (Exception e) {
            error = true;
        } 
        finally {
            if (error) { 
                JOptionPane.showMessageDialog(null, "ERROR INGRESA LLENA LOS CAMPOS", "Error",JOptionPane.ERROR_MESSAGE);
            }
        }
    }
}