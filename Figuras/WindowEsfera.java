package Figuras;

import javax.swing.*;
import java.awt.*;
import java.awt.event.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

public class WindowEsfera extends JFrame implements ActionListener {
    private Container Layout;
    private JLabel TextoRadio, TextoVolumen, TextoSuperficie;
    private JTextField InputRadio;
    private JButton BotonCalcular; 
    public WindowEsfera() {
        inicio();
        setTitle("Esfera"); 
        setSize(280,200);
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
        BotonCalcular = new JButton();
        BotonCalcular.setText("Calcular");
        BotonCalcular.setBounds(75, 50, 135, 23); 
        BotonCalcular.addActionListener(this);
        TextoVolumen = new JLabel();
        TextoVolumen.setText("Volumen [cm^3]:");
        TextoVolumen.setBounds(20, 90, 200, 23);
        TextoSuperficie = new JLabel();
        TextoSuperficie.setText("Superficie [cm^2]:");
        TextoSuperficie.setBounds(20, 120, 200, 23);
        Layout.add(TextoRadio);
        Layout.add(InputRadio);
        Layout.add(BotonCalcular);
        Layout.add(TextoVolumen);
        Layout.add(TextoSuperficie);
    }
    
    public void actionPerformed(ActionEvent evento) {
        if (evento.getSource() == BotonCalcular) { 
            boolean error = false;
            try {
                double radio = Double.parseDouble(InputRadio.getText());
                Esfera esfera = new Esfera(radio); 
                TextoVolumen.setText("Volumen (cm^3): " + String.format("%.2f", esfera.VolumenEsfera()));
                TextoSuperficie.setText("Superficie (cm^2): " + String.format("%.2f",esfera.SuperficieEsfera()));
            } 
            catch (Exception e) {
                error = true;
            } 
            finally {
                if(error) { 
                    JOptionPane.showMessageDialog(null,"ERROR INGRESA LLENA LOS CAMPOS", "Error", JOptionPane.ERROR_MESSAGE);
                }
            }
        }
    }
}