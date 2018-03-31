
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.util.Vector;

/*
 * EditTypeFrame.java
 *
 * Created on 2016年3月30日, 上午2:38
 */
import javax.swing.JOptionPane;
import javax.swing.table.DefaultTableModel;



/**
 *
 * @author  Administrator
 */
public class EditTypeFrame extends javax.swing.JFrame {
    
    /** Creates new form EditTypeFrame */
    public EditTypeFrame() {
        initComponents();
        this.clearJTable();
        this.initJTable();
    }
    
    /** This method is called from within the constructor to
     * initialize the form.
     * WARNING: Do NOT modify this code. The content of this method is
     * always regenerated by the Form Editor.
     */
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        jScrollPane1 = new javax.swing.JScrollPane();
        jTableType = new javax.swing.JTable();
        jbSave = new javax.swing.JButton();
        jbExit = new javax.swing.JButton();
        jLabel1 = new javax.swing.JLabel();
        jLabel2 = new javax.swing.JLabel();
        jtfTypeID = new javax.swing.JTextField();
        jtfTypeName = new javax.swing.JTextField();
        jButton1 = new javax.swing.JButton();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);

        jTableType.setModel(new javax.swing.table.DefaultTableModel(
            new Object [][] {
                {null, null},
                {null, null},
                {null, null},
                {null, null}
            },
            new String [] {
                "类型ID", "电影类型"
            }
        ));
        jTableType.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                jTableTypeMouseClicked(evt);
            }
        });
        jScrollPane1.setViewportView(jTableType);

        jbSave.setText("保存");
        jbSave.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jbSaveActionPerformed(evt);
            }
        });

        jbExit.setText("退出");
        jbExit.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jbExitActionPerformed(evt);
            }
        });

        jLabel1.setText("类型ID：");

        jLabel2.setText("电影类型：");

        jtfTypeID.setEditable(false);

        jButton1.setText("删除");
        jButton1.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jButton1ActionPerformed(evt);
            }
        });

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addComponent(jScrollPane1, javax.swing.GroupLayout.DEFAULT_SIZE, 400, Short.MAX_VALUE)
            .addGroup(layout.createSequentialGroup()
                .addGap(90, 90, 90)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING)
                    .addComponent(jLabel1)
                    .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                        .addComponent(jbSave)
                        .addComponent(jLabel2)))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING)
                    .addGroup(layout.createSequentialGroup()
                        .addComponent(jButton1)
                        .addGap(18, 18, 18)
                        .addComponent(jbExit))
                    .addComponent(jtfTypeName, javax.swing.GroupLayout.Alignment.LEADING, javax.swing.GroupLayout.DEFAULT_SIZE, 152, Short.MAX_VALUE)
                    .addComponent(jtfTypeID, javax.swing.GroupLayout.Alignment.LEADING, javax.swing.GroupLayout.PREFERRED_SIZE, 38, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addGap(94, 94, 94))
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addComponent(jScrollPane1, javax.swing.GroupLayout.PREFERRED_SIZE, 156, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(jLabel1)
                    .addComponent(jtfTypeID, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(jLabel2)
                    .addComponent(jtfTypeName, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addGap(18, 18, 18)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(jbSave)
                    .addComponent(jbExit)
                    .addComponent(jButton1))
                .addContainerGap(20, Short.MAX_VALUE))
        );

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void jbExitActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jbExitActionPerformed
        // TODO add your handling code here:
        this.setVisible(false);
    }//GEN-LAST:event_jbExitActionPerformed

    private void jbSaveActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jbSaveActionPerformed
        // TODO add your handling code here:
        int id=Integer.parseInt(this.jtfTypeID.getText().trim());
        String name=this.jtfTypeName.getText().trim();
 
        MovieType type=new MovieType();
        type.setTypeid(id);
        type.setTypeName(name);      
        int i=type.EditType(type);
        if(i>0){
            JOptionPane.showMessageDialog(null,"修改成功！");
            
        }else{
            JOptionPane.showMessageDialog(null,"修改失败！");
        }
        this.clearJTable();
        this.initJTable();
        this.resetTypee();
    }//GEN-LAST:event_jbSaveActionPerformed

    private void jTableTypeMouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_jTableTypeMouseClicked
        // TODO add your handling code here:
        MovieType mt=new MovieType();
         int selectRow=this.jTableType.getSelectedRow();
        DefaultTableModel dtm=(DefaultTableModel) this.jTableType.getModel();
        this.jtfTypeID.setText(String.valueOf( dtm.getValueAt(selectRow,0 )));
        this.jtfTypeName.setText((String) dtm.getValueAt(selectRow,1 ));
    
    }//GEN-LAST:event_jTableTypeMouseClicked

    private void jButton1ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButton1ActionPerformed
        // TODO add your handling code here:
        this.DeleteType();
        this.clearJTable();
        this.initJTable();
        this.resetTypee();
    }//GEN-LAST:event_jButton1ActionPerformed
    
    /**
     * @param args the command line arguments
     */
    public static void main(String args[]) {
        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                new EditTypeFrame().setVisible(true);
            }
        });
    }
      public void DeleteType(){
        int i = 0;
        MovieType type=new MovieType();
        int typeid=Integer.parseInt(this.jtfTypeID.getText().trim());
        type.setTypeid(typeid);
             
        Connection con=null;
        PreparedStatement pstmt=null;
        String sql="Delete from type where typeid = ?";
        
        try{
            con=MovieDB.getCon();
            pstmt=con.prepareStatement(sql);          
            pstmt.setInt(1,type.getTypeid());      
            
            i=pstmt.executeUpdate();
        }catch(Exception ex){
            ex.printStackTrace();
        }finally{
            try{
                pstmt.close();
                con.close();
            }catch(Exception ex){
                ex.printStackTrace();
            }
        }
        if(i>0){
            JOptionPane.showMessageDialog(null, "删除成功！");
        }else
        {
            JOptionPane.showMessageDialog(null, "删除失败！");
        }
   }
   public void initJTable(){
    
        MovieType mt= new MovieType();
        Vector vector=mt.getAllTypes();
        DefaultTableModel dtm=(DefaultTableModel) this.jTableType.getModel();
        for(int i =0; i < vector.size();i++){
            dtm.addRow((Vector)vector.get(i));
        }
     }
    public void clearJTable(){
       DefaultTableModel dtm=(DefaultTableModel) this.jTableType.getModel();
       int rowCount=dtm.getRowCount();
       for(int i=0;i<rowCount;i++){
           dtm.removeRow(0);
       }
    }
    public void resetTypee(){
      this.jtfTypeID.setText("");
      this.jtfTypeName.setText("");  
    }
    
    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton jButton1;
    private javax.swing.JLabel jLabel1;
    private javax.swing.JLabel jLabel2;
    private javax.swing.JScrollPane jScrollPane1;
    private javax.swing.JTable jTableType;
    private javax.swing.JButton jbExit;
    private javax.swing.JButton jbSave;
    private javax.swing.JTextField jtfTypeID;
    private javax.swing.JTextField jtfTypeName;
    // End of variables declaration//GEN-END:variables

   
    
}
