using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;
using UnityEngine.UI;


public class Ecg : MonoBehaviour
{
    public string portName = "COM3";
    public int baudRate = 9600;
    public Text textUI1; // ระบุ UI Text 1 จาก Inspector
    public Text textUI2; // ระบุ UI Text 2 จาก Inspector

    private SerialPort serialPort;

    // Start is called before the first frame update
    void Start()
    {
        serialPort = new SerialPort(portName, baudRate);
        serialPort.Open();
        serialPort.ReadTimeout = 1000;
    }

    // Update is called once per frame
    void Update()
    {
        if (serialPort.IsOpen)
        {
            try
            {
                string data = serialPort.ReadLine();

                // แบ่งข้อมูลออกเป็นสองค่า
                string[] values = data.Split(',');
                textUI1.text = "Ecg Value: " + values[0];
                textUI2.text = "BPM: " + values[1];
                Debug.Log("Data from Arduino: " + data);
            }
            catch (System.Exception)
            {
                // จัดการข้อผิดพลาดในการอ่านข้อมูล
            }
        }
    }

    void OnApplicationQuit()
    {
        if (serialPort != null && serialPort.IsOpen)
        {
            serialPort.Close();
        }
    }
}
