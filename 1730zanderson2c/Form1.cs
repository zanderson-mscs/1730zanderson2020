using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1730zanderson2c
{
    public partial class Form1 : Form
    {
        private byte byte1, byte2, byte3;
        private sbyte sbyte1, sbyte2, sbyte3;
        private short short1, short2, short3;
        private ushort ushort1, ushort2, ushort3;
        private int int1, int2, int3;
        private uint uint1, uint2, uint3;
        private long long1, long2, long3;
        private ulong ulong1, ulong2, ulong3;
        private float float1, float2, float3;
        private double double1, double2, double3;
        private decimal decimal1, decimal2, decimal3;

        private void divideButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.byte3 = Convert.ToByte(this.byte1 / this.byte2);
                txtbyte3.Text = byte3.ToString();
            }
            catch (Exception) { txtbyte3.Text = "error"; byte1 = 0; }
            try
            {
                this.sbyte3 = Convert.ToSByte(this.sbyte1 / this.sbyte2);
                txtsbyte3.Text = sbyte3.ToString();
            }
            catch (Exception) { txtsbyte3.Text = "error"; sbyte1 = 0; }
            try
            {
                this.short3 = Convert.ToInt16(this.short1 / this.short2);
                txtshort3.Text = short3.ToString();
            }
            catch (Exception) { txtshort3.Text = "error"; short1 = 0; }
            try
            {
                this.ushort3 = Convert.ToUInt16(this.ushort1 / this.ushort2);
                txtushort3.Text = ushort3.ToString();
            }
            catch (Exception) { txtushort3.Text = "error"; ushort1 = 0; }
            try
            {
                this.int3 = checked(this.int1 / this.int2);
                txtint3.Text = int3.ToString();
            }
            catch (Exception) { txtint3.Text = "error"; int1 = 0; }
            try
            {
                this.uint3 = checked(this.uint1 / this.uint2);
                txtuint3.Text = uint3.ToString();
            }
            catch (Exception) { txtuint3.Text = "error"; uint1 = 0; }
            try
            {
                this.long3 = Convert.ToInt64(this.long1 / this.long2);
                txtlong3.Text = long3.ToString();
            }
            catch (Exception) { txtlong3.Text = "error"; long1 = 0; }
            try
            {
                this.ulong3 = Convert.ToUInt64(this.ulong1 / this.ulong2);
                txtulong3.Text = ulong3.ToString();
            }
            catch (Exception) { txtulong3.Text = "error"; ulong1 = 0; }
            try
            {
                this.float3 = Convert.ToSingle(this.float1 / this.float2);
                txtfloat3.Text = float3.ToString();
            }
            catch (Exception) { txtfloat3.Text = "error"; float1 = 0.0f; }
            try
            {
                this.double3 = Convert.ToDouble(this.double1 / this.double2);
                txtdouble3.Text = double3.ToString();
            }
            catch (Exception) { txtdouble3.Text = "error"; double1 = 0.0; }
            try
            {
                this.decimal3 = Convert.ToDecimal(this.decimal1 / this.decimal2);
                txtdecimal3.Text = decimal3.ToString();
            }
            catch (Exception) { txtdecimal3.Text = "error"; decimal1 = 0m; }
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {

                try
                {
                    this.byte3 = Convert.ToByte(this.byte1 * this.byte2);
                    txtbyte3.Text = byte3.ToString();
                }
                catch (Exception) { txtbyte3.Text = "error"; byte1 = 0; }
                try
                {
                    this.sbyte3 = Convert.ToSByte(this.sbyte1 * this.sbyte2);
                    txtsbyte3.Text = sbyte3.ToString();
                }
                catch (Exception) { txtsbyte3.Text = "error"; sbyte1 = 0; }
                try
                {
                    this.short3 = Convert.ToInt16(this.short1 * this.short2);
                    txtshort3.Text = short3.ToString();
                }
                catch (Exception) { txtshort3.Text = "error"; short1 = 0; }
                try
                {
                    this.ushort3 = Convert.ToUInt16(this.ushort1 * this.ushort2);
                    txtushort3.Text = ushort3.ToString();
                }
                catch (Exception) { txtushort3.Text = "error"; ushort1 = 0; }
                try
                {
                    this.int3 = checked(this.int1 * this.int2);
                    txtint3.Text = int3.ToString();
                }
                catch (Exception) { txtint3.Text = "error"; int1 = 0; }
                try
                {
                    this.uint3 = checked(this.uint1 * this.uint2);
                    txtuint3.Text = uint3.ToString();
                }
                catch (Exception) { txtuint3.Text = "error"; uint1 = 0; }
                try
                {
                    this.long3 = Convert.ToInt64(this.long1 * this.long2);
                    txtlong3.Text = long3.ToString();
                }
                catch (Exception) { txtlong3.Text = "error"; long1 = 0; }
                try
                {
                    this.ulong3 = Convert.ToUInt64(this.ulong1 * this.ulong2);
                    txtulong3.Text = ulong3.ToString();
                }
                catch (Exception) { txtulong3.Text = "error"; ulong1 = 0; }
                try
                {
                    this.float3 = Convert.ToSingle(this.float1 * this.float2);
                    txtfloat3.Text = float3.ToString();
                }
                catch (Exception) { txtfloat3.Text = "error"; float1 = 0.0f; }
                try
                {
                    this.double3 = Convert.ToDouble(this.double1 * this.double2);
                    txtdouble3.Text = double3.ToString();
                }
                catch (Exception) { txtdouble3.Text = "error"; double1 = 0.0; }
                try
                {
                    this.decimal3 = Convert.ToDecimal(this.decimal1 * this.decimal2);
                    txtdecimal3.Text = decimal3.ToString();
                }
                catch (Exception) { txtdecimal3.Text = "error"; decimal1 = 0m; }
            
        }

        private void subtractButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.byte3 = Convert.ToByte(this.byte1 - this.byte2);
                txtbyte3.Text = byte3.ToString();
            }
            catch (Exception) { txtbyte3.Text = "error"; byte1 = 0; }
            try
            {
                this.sbyte3 = Convert.ToSByte(this.sbyte1 - this.sbyte2);
                txtsbyte3.Text = sbyte3.ToString();
            }
            catch (Exception) { txtsbyte3.Text = "error"; sbyte1 = 0; }
            try
            {
                this.short3 = Convert.ToInt16(this.short1 - this.short2);
                txtshort3.Text = short3.ToString();
            }
            catch (Exception) { txtshort3.Text = "error"; short1 = 0; }
            try
            {
                this.ushort3 = Convert.ToUInt16(this.ushort1 - this.ushort2);
                txtushort3.Text = ushort3.ToString();
            }
            catch (Exception) { txtushort3.Text = "error"; ushort1 = 0; }
            try
            {
                this.int3 = checked(this.int1 - this.int2);
                txtint3.Text = int3.ToString();
            }
            catch (Exception) { txtint3.Text = "error"; int1 = 0; }
            try
            {
                this.uint3 = checked(this.uint1 - this.uint2);
                txtuint3.Text = uint3.ToString();
            }
            catch (Exception) { txtuint3.Text = "error"; uint1 = 0; }
            try
            {
                this.long3 = Convert.ToInt64(this.long1 - this.long2);
                txtlong3.Text = long3.ToString();
            }
            catch (Exception) { txtlong3.Text = "error"; long1 = 0; }
            try
            {
                this.ulong3 = Convert.ToUInt64(this.ulong1 - this.ulong2);
                txtulong3.Text = ulong3.ToString();
            }
            catch (Exception) { txtulong3.Text = "error"; ulong1 = 0; }
            try
            {
                this.float3 = Convert.ToSingle(this.float1 - this.float2);
                txtfloat3.Text = float3.ToString();
            }
            catch (Exception) { txtfloat3.Text = "error"; float1 = 0.0f; }
            try
            {
                this.double3 = Convert.ToDouble(this.double1 - this.double2);
                txtdouble3.Text = double3.ToString();
            }
            catch (Exception) { txtdouble3.Text = "error"; double1 = 0.0; }
            try
            {
                this.decimal3 = Convert.ToDecimal(this.decimal1 - this.decimal2);
                txtdecimal3.Text = decimal3.ToString();
            }
            catch (Exception) { txtdecimal3.Text = "error"; decimal1 = 0m; }
        }
        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.byte3 = Convert.ToByte(this.byte1 + this.byte2);
                txtbyte3.Text = byte3.ToString();
            }
            catch (Exception) { txtbyte3.Text = "error"; byte1 = 0; }
            try
            {
                this.sbyte3 = Convert.ToSByte(this.sbyte1 + this.sbyte2);
                txtsbyte3.Text = sbyte3.ToString();
            }
            catch (Exception) { txtsbyte3.Text = "error"; sbyte1 = 0; }
            try
            {
                this.short3 = Convert.ToInt16(this.short1 + this.short2);
                txtshort3.Text = short3.ToString();
            }
            catch (Exception) { txtshort3.Text = "error"; short1 = 0; }
            try
            {
                this.ushort3 = Convert.ToUInt16(this.ushort1 + this.ushort2);
                txtushort3.Text = ushort3.ToString();
            }
            catch (Exception) { txtushort3.Text = "error"; ushort1 = 0; }
            try
            {
                this.int3 = checked(this.int1 + this.int2);
                txtint3.Text = int3.ToString();
            }
            catch (Exception) { txtint3.Text = "error"; int1 = 0; }
            try
            {
                this.uint3 = checked(this.uint1 + this.uint2);
                txtuint3.Text = uint3.ToString();
            }
            catch (Exception) { txtuint3.Text = "error"; uint1 = 0; }
            try
            {
                this.long3 = Convert.ToInt64(this.long1 + this.long2);
                txtlong3.Text = long3.ToString();
            }
            catch (Exception) { txtlong3.Text = "error"; long1 = 0; }
            try
            {
                this.ulong3 = Convert.ToUInt64(this.ulong1 + this.ulong2);
                txtulong3.Text = ulong3.ToString();
            }
            catch (Exception) { txtulong3.Text = "error"; ulong1 = 0; }
            try
            {
                this.float3 = Convert.ToSingle(this.float1 + this.float2);
                txtfloat3.Text = float3.ToString();
            }
            catch (Exception) { txtfloat3.Text = "error"; float1 = 0.0f; }
            try
            {
                this.double3 = Convert.ToDouble(this.double1 + this.double2);
                txtdouble3.Text = double3.ToString();
            }
            catch (Exception) { txtdouble3.Text = "error"; double1 = 0.0; }
            try
            {
                this.decimal3 = Convert.ToDecimal(this.decimal1 + this.decimal2);
                txtdecimal3.Text = decimal3.ToString();
            }
            catch (Exception) { txtdecimal3.Text = "error"; decimal1 = 0m; }

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox33_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnMinimum_Click(object sender, EventArgs e)
        {
            

            byte1 = Byte.MinValue;          txtbyte1.Text = byte1.ToString();
            sbyte1 = SByte.MinValue;        txtsbyte1.Text = sbyte1.ToString();
            short1 = Int16.MinValue;        txtshort1.Text = short1.ToString();
            ushort1 = UInt16.MinValue;      txtushort1.Text = ushort1.ToString();
            int1 = Int32.MinValue;          txtint1.Text = int1.ToString();
            uint1 = UInt32.MinValue;        txtuint1.Text = uint1.ToString();
            long1 = Int64.MinValue;         txtlong1.Text = long1.ToString();
            ulong1 = UInt64.MinValue;       txtulong1.Text = ulong1.ToString();
            float1 = Single.MinValue;       txtfloat1.Text = float1.ToString();
            double1 = Double.MinValue;      txtdouble1.Text = double1.ToString();
            decimal1 = Decimal.MinValue;    txtdecimal1.Text = decimal1.ToString();


        }

      

        private void btnMaximum_Click(object sender, EventArgs e)
        {
            

            byte2 = Byte.MaxValue; txtbyte2.Text = byte2.ToString();
            sbyte2 = SByte.MaxValue; txtsbyte2.Text = sbyte2.ToString();
            short2 = Int16.MaxValue; txtshort2.Text = short2.ToString();
            ushort2 = UInt16.MaxValue; txtushort2.Text = ushort2.ToString();
            int2 = Int32.MaxValue; txtint2.Text = int2.ToString();
            uint2 = UInt32.MaxValue; txtuint2.Text = uint2.ToString();
            long2 = Int64.MaxValue; txtlong2.Text = long2.ToString();
            ulong2 = UInt64.MaxValue; txtulong2.Text = ulong2.ToString();
            float2 = Single.MaxValue; txtfloat2.Text = float2.ToString();
            double2 = Double.MaxValue; txtdouble2.Text = double2.ToString();
            decimal2 = Decimal.MaxValue; txtdecimal2.Text = decimal2.ToString();
        }

        private void InputTextBox1_TextChanged(object sender, EventArgs e)
        {
            

            try
            {
                byte1 = Convert.ToByte(inputTextBox1.Text);
                txtbyte1.Text = byte1.ToString();
            }
            catch (Exception) { txtbyte1.Text = "error"; }
            try
            {
                sbyte1 = Convert.ToSByte(inputTextBox1.Text);
                txtsbyte1.Text = sbyte1.ToString();
            }
            catch (Exception) { txtsbyte1.Text = "error"; }
            try
            {
                short1 = Convert.ToInt16(inputTextBox1.Text);
                txtshort1.Text = short1.ToString();
            }
            catch (Exception) { txtshort1.Text = "error"; }
            try
            {
                ushort1 = Convert.ToUInt16(inputTextBox1.Text);
                txtushort1.Text = ushort1.ToString();
            }
            catch (Exception) { txtushort1.Text = "error"; }
            try
            {
                int1 = Convert.ToInt32(inputTextBox1.Text);
                txtint1.Text = int1.ToString();
            }
            catch (Exception) { txtint1.Text = "error"; }
            try
            {
                uint1 = Convert.ToUInt32(inputTextBox1.Text);
                txtuint1.Text = uint1.ToString();
            }
            catch (Exception) { txtuint1.Text = "error"; }
            try
            {
                long1 = Convert.ToInt64(inputTextBox1.Text);
                txtlong1.Text = long1.ToString();
            }
            catch (Exception) { txtlong1.Text = "error"; }
            try
            {
                ulong1 = Convert.ToUInt64(inputTextBox1.Text);
                txtulong1.Text = ulong1.ToString();
            }
            catch (Exception) { txtulong1.Text = "error"; }
            try
            {
                float1 = Convert.ToSingle(inputTextBox1.Text);
                txtfloat1.Text = float1.ToString();
            }
            catch (Exception) { txtfloat1.Text = "error"; }
            try
            {
                double1 = Convert.ToDouble(inputTextBox1.Text);
                txtdouble1.Text = double1.ToString();
            }
            catch (Exception) { txtdouble1.Text = "error"; }
            try
            {
                decimal1 = Convert.ToDecimal(inputTextBox1.Text);
                txtdecimal1.Text = decimal1.ToString();
            }
            catch (Exception) { txtdecimal1.Text = "error"; }
        }
        private void InputTextBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                byte2 = Convert.ToByte(inputTextBox2.Text);
                txtbyte2.Text = byte2.ToString();
            }
            catch (Exception) { txtbyte2.Text = "error"; }
            try
            {
                sbyte2 = Convert.ToSByte(inputTextBox2.Text);
                txtsbyte2.Text = sbyte2.ToString();
            }
            catch (Exception) { txtsbyte2.Text = "error"; }
            try
            {
                short2 = Convert.ToInt16(inputTextBox2.Text);
                txtshort2.Text = short2.ToString();
            }
            catch (Exception) { txtshort2.Text = "error"; }
            try
            {
                ushort2 = Convert.ToUInt16(inputTextBox2.Text);
                txtushort2.Text = ushort2.ToString();
            }
            catch (Exception) { txtushort2.Text = "error"; }
            try
            {
                int2 = Convert.ToInt32(inputTextBox2.Text);
                txtint2.Text = int2.ToString();
            }
            catch (Exception) { txtint2.Text = "error"; }
            try
            {
                uint2 = Convert.ToUInt32(inputTextBox2.Text);
                txtuint2.Text = uint2.ToString();
            }
            catch (Exception) { txtuint2.Text = "error"; }
            try
            {
                long2 = Convert.ToInt64(inputTextBox2.Text);
                txtlong2.Text = long2.ToString();
            }
            catch (Exception) { txtlong2.Text = "error"; }
            try
            {
                ulong2 = Convert.ToUInt64(inputTextBox2.Text);
                txtulong2.Text = ulong2.ToString();
            }
            catch (Exception) { txtulong2.Text = "error"; }
            try
            {
                float2 = Convert.ToSingle(inputTextBox2.Text);
                txtfloat2.Text = float2.ToString();
            }
            catch (Exception) { txtfloat2.Text = "error"; }
            try
            {
                double2 = Convert.ToDouble(inputTextBox2.Text);
                txtdouble2.Text = double2.ToString();
            }
            catch (Exception) { txtdouble2.Text = "error"; }
            try
            {
                decimal2 = Convert.ToDecimal(inputTextBox2.Text);
                txtdecimal2.Text = decimal2.ToString();
            }
            catch (Exception) { txtdecimal2.Text = "error"; }
        }


    }

}
