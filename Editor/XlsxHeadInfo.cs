﻿namespace Wsh.Xlsx.Editor {

    public class XlsxHeadInfo {
        
        public int Index => m_index;
        public string Name => m_name;
        public string ValueType => m_valueType;

        private int m_index;
        private string m_name;
        private string m_valueType;

        public XlsxHeadInfo(int index, string name, string valueType) {
            m_index = index;
            m_name = name;
            m_valueType = valueType;
        }

        public override string ToString() {
            return "{Index: " + Index + " Name: " + Name + " ValueType: " + ValueType + "}";
        }

        public void Dispose() {
            m_index = 0;
            m_name = null;
            m_valueType= null;
        }

    }

}