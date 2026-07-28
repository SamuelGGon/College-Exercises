import javax.swing.JFrame;
import javax.swing.JSlider;

import java.awt.*;



public class SistemaSolar extends Canvas{
    int redc1 = 255;
    int greenc1 = 255;
    int bluec1 = 255;

    public void qualquerCirculo(Graphics gr, int eixoX, int eixoY, int tamanho, int red, int green, int blue){

    
        gr.fillOval(eixoX, eixoY, tamanho, tamanho);
        gr.setColor(new Color(red, green, blue));
        
        
    }
    
    @Override
    public void paint(Graphics g){
        
        qualquerCirculo(g, (getWidth() / 2) , (getHeight() / 2), 10, redc1, greenc1, bluec1);
        qualquerCirculo(g, ((getWidth() / 2) - 100) , (getHeight() / 2), 10, 128, 128, 128);

    }

    public static void main(String [] args){

        SistemaSolar sol =  new SistemaSolar();
        JFrame telaSpace = new JFrame();
        JSlider slider = new JSlider(0, 255, 255);

        telaSpace.getContentPane().setBackground(Color.BLACK);
        
        telaSpace.setSize(800, 600);
        telaSpace.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        
        slider.setMajorTickSpacing(10);
        slider.setMinorTickSpacing(1);
        slider.setPaintTicks(false);
        slider.setPaintLabels(false);
        slider.setOpaque(false);
        slider.setBackground(new Color(0, 0,0,0));
        //slider.setBorder(null);
        slider.setPreferredSize(new Dimension(50, 50));

        slider.addChangeListener(new javax.swing.event.ChangeListener() {
            @Override
            public void stateChanged(javax.swing.event.ChangeEvent e){
                int valor = slider.getValue();
                sol.redc1 = valor;
                sol.greenc1 = valor;
                sol.bluec1 = valor;
                sol.repaint();
            }
        });

        sol.setPreferredSize(new Dimension(800, 600));

        telaSpace.setLayout(new FlowLayout());
        telaSpace.add(slider);
        telaSpace.add(sol);
        telaSpace.setVisible(true);




    }
    
}
