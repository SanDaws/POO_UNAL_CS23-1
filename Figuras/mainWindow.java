package Figuras;
import java.awt.*;
import javax.swing.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

public class mainWindow extends JFrame implements ActionListener {
    private Container layout;
    private JButton BotonCilindro, BotonEsfera, BotonPirámide;
    public mainWindow(){
        inicio();
        setTitle("Figura"); 
        setSize(350,160); 
        setLocationRelativeTo(null); 
        setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
    }
    
    private void inicio() {
        layout = getContentPane(); 
        layout.setLayout(null); 
        BotonCilindro = new JButton();
        BotonCilindro.setText("Cilindro");
        BotonCilindro.setBounds(125, 25, 80, 23); 
        BotonCilindro.addActionListener(this);
        BotonEsfera = new JButton();
        BotonEsfera.setText("Esfera");
        BotonEsfera.setBounds(125, 55, 80, 23); 
        BotonEsfera.addActionListener(this);
        BotonPirámide = new JButton();
        BotonPirámide.setText("Pirámide");
        BotonPirámide.setBounds(115, 85, 100, 23); 
        BotonPirámide.addActionListener(this);
        layout.add(BotonCilindro);
        layout.add(BotonEsfera);
        layout.add(BotonPirámide);
    }
    
    public void actionPerformed(ActionEvent evento) {
        if (evento.getSource() == BotonCilindro) { 
            WindowCilindro cilindro = new WindowCilindro(); 
            cilindro.setVisible(true); 
        }
        if (evento.getSource() == BotonEsfera) { 
            WindowEsfera esfera = new WindowEsfera(); 
            esfera.setVisible(true); 
        }
        if (evento.getSource() == BotonPirámide) { 
            WindowPiramide pirámide = new WindowPiramide(); 
            pirámide.setVisible(true); 
        }
    }
}