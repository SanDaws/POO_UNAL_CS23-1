package Figuras;

import javax.swing.*;
import java.awt.*;
import java.awt.event.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

public class WindowCilindro extends JFrame implements ActionListener {
    
    private Container Layout;
    private JLabel TextoRadio, TextoAltura, TextoVolumen, TextoSuperficie;
    private JTextField InputRadio, InputAltura;
    private JButton BotonCalcular;
    
    public WindowCilindro() {
        inicio();
        setTitle("Cilindro"); 
        setSize(280,210); 
        setLocationRelativeTo(null); 
        setResizable(false); 
    }
    
    private void inicio() {
        Layout = getContentPane(); 
        Layout.setLayout(null); 
        TextoRadio = new JLabel();
        TextoRadio.setText("Radio [cm]:");
        TextoRadio.setBounds(20, 20, 135, 23); 
        InputRadio = new JTextField();
        InputRadio.setBounds(100, 20, 135, 23);
        TextoAltura = new JLabel();
        TextoAltura.setText("Altura [cm]:");
        TextoAltura.setBounds(20, 50, 135, 23); 
        InputAltura = new JTextField();
        InputAltura.setBounds(100, 50, 135, 23);
        BotonCalcular = new JButton();
        BotonCalcular.setText("Calcular");
        BotonCalcular.setBounds(75, 80, 135, 23);
        BotonCalcular.addActionListener(this);
        TextoVolumen = new JLabel();
        TextoVolumen.setText("Volumen [cm^3]:");
        TextoVolumen.setBounds(20, 110, 200, 23);
        TextoSuperficie = new JLabel();
        TextoSuperficie.setText("Superficie [cm^2]:");
        TextoSuperficie.setBounds(20, 140, 200, 23);
        Layout.add(TextoRadio);
        Layout.add(InputRadio);
        Layout.add(TextoAltura);
        Layout.add(InputAltura);
        Layout.add(BotonCalcular);
        Layout.add(TextoVolumen);
        Layout.add(TextoSuperficie);
    }
    public void actionPerformed(ActionEvent event) {
        
        boolean error = false; 
        double radio = 0;
        double altura = 0;
        try {
            radio = Double.parseDouble(InputRadio.getText());
            altura = Double.parseDouble(InputAltura.getText());
            Cilindro cilindro = new Cilindro(radio, altura); 
            TextoVolumen.setText("Volumen (cm^3): " + String.format("%.2f",cilindro.VolumenCilindro()));
            TextoSuperficie.setText("Superficie (cm^2): " + String.format("%.2f",cilindro.SuperficieCilindro()));
            } 
        catch (Exception e){
            error = true; 
        } 
        finally {
            if(error) { 
                JOptionPane.showMessageDialog(null,"ERROR INGRESA LLENA LOS CAMPOS", "Error", JOptionPane.ERROR_MESSAGE);
            }
        }
    }
}
