/************************************************************

  Copyright (c) 2008��ybkj_zlg
  Author:               Created Time: 2016/12/20 19:33:27
  Description:    ���ݱ�T_ejiCategory��Ӧ��ҵ���߼���T_ejiCategory
  Version:         2.1.0.0
  * �Դ��ļ��ĸ��Ŀ��ܻᵼ�²���ȷ����Ϊ���������
     �������ɴ��룬��Щ���Ľ��ᶪʧ����������չ����
 * ʵ���Լ��� T_ejiCategory_Entity:T_ejiCategory
 * 
************************************************************/
/************************************************************
SQL���룺
select Id,Pid,Ejiname,Isshow,Icom from T_ejiCategory
delete from T_ejiCategory
INSERT INTO T_ejiCategory (Id,Pid,Ejiname,Isshow,Icom)
     VALUES
           ('','','','','')
UPDATE T_ejiCategory SET ...
������ֵ���룺
 *         valObj.Id = valObj2.Id;
        valObj.Pid = valObj2.Pid;
        valObj.Ejiname = valObj2.Ejiname;
        valObj.Isshow = valObj2.Isshow;
        valObj.Icom = valObj2.Icom; 
        valObj.Id = "";
        valObj.Pid = "";
        valObj.Ejiname = "";
        valObj.Isshow = "";
        valObj.Icom = ""; 
        "Id": $("#txt_Id").val(),
        "Pid": $("#txt_Pid").val(),
        "Ejiname": $("#txt_Ejiname").val(),
        "Isshow": $("#txt_Isshow").val(),
        "Icom": $("#txt_Icom").val(), 
 * ************************************************************/
using System;
using System.Data;
using System.Collections.Generic;
using System.Collections;
using System.Reflection;
using AgileFrame.Orm.PersistenceLayer.DAL.Base;
using AgileFrame.Orm.PersistenceLayer.BLL.Base;
using AgileFrame.Orm.PersistenceLayer.Model;
using AgileFrame.Core;
namespace AgileFrame.Orm.PersistenceLayer.Model
{
    /// <summary>
    /// <para></para>
    /// <para>��T_ejiCategory���ݱ��Ӧ��ʵ�����</para>
    /// <para>����һ�������еķ����ǣ���"���ֶ�"������һ��bool��ʶλ����"Attribute"���� </para>
    /// </summary>    
    [Serializable]
    public class T_ejiCategory : ITableImplement
    {
        /// <summary>��������  </summary>
        public static T_ejiCategory Factory()
        {
            return new T_ejiCategory();
        }
		#region ���ֶ��嵥 ����������������ͼ��ʱ��һ���Լ��
        #region ���ֶ��嵥1
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IDENTITY </summary>
        public int _Id
        {            
            get { return this.Id; }
            set { this.Id = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Pid
        {            
            get { return this.Pid; }
            set { this.Pid = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Ejiname
        {            
            get { return this.Ejiname; }
            set { this.Ejiname = value; }
        }
        
        /// <summary> [CtrlTypeDic-{CheckBoxList}] Attribute </summary>
        public bool _Isshow
        {            
            get { return this.Isshow; }
            set { this.Isshow = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Icom
        {            
            get { return this.Icom; }
            set { this.Icom = value; }
        }
        #endregion
        #region ���ֶ��嵥2
        
        /// <summary> [CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public int Id
        {
            get { return this.m_id; }
            set //private 
            {
                if (!id_initialized || m_id != value)
                {
                    this.m_id = value;
                }
                id_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Pid
        {
            get { return this.m_pid; }
            set //
            {
                if (!pid_initialized || m_pid != value)
                {
                    this.m_pid = value;
                }
                pid_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Ejiname
        {
            get { return this.m_ejiname; }
            set //
            {
                if (!ejiname_initialized || m_ejiname != value)
                {
                    this.m_ejiname = value;
                }
                ejiname_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{CheckBoxList}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public bool Isshow
        {
            get { return this.m_isshow; }
            set //
            {
                if (!isshow_initialized || m_isshow != value)
                {
                    this.m_isshow = value;
                }
                isshow_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Icom
        {
            get { return this.m_icom; }
            set //
            {
                if (!icom_initialized || m_icom != value)
                {
                    this.m_icom = value;
                }
                icom_initialized = true;
            }
        }    
        #endregion
        #region Attribute�嵥 �������
        /// <summary>
        /// {�ֶ�����-�ṹ����}
        /// </summary>
        public class Attribute
        {
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Id =  new AttributeItem("[T_ejiCategory].[Id]", typeof(int), 4);
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Pid =  new AttributeItem("[T_ejiCategory].[Pid]", typeof(string), 50);
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Ejiname =  new AttributeItem("[T_ejiCategory].[Ejiname]", typeof(string), 50);
            
            /// <summary>[CtrlTypeDic-{CheckBoxList}]</summary>
            public static AttributeItem Isshow =  new AttributeItem("[T_ejiCategory].[Isshow]", typeof(bool), 1);
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Icom =  new AttributeItem("[T_ejiCategory].[Icom]", typeof(string), 50);
        }
        #endregion
        #region bool�嵥 �������
        
        private int m_id;
        /// <summary></summary>
        protected bool id_initialized = false;
        
        private string m_pid;
        /// <summary></summary>
        protected bool pid_initialized = false;
        
        private string m_ejiname;
        /// <summary></summary>
        protected bool ejiname_initialized = false;
        
        private bool m_isshow;
        /// <summary></summary>
        protected bool isshow_initialized = false;
        
        private string m_icom;
        /// <summary></summary>
        protected bool icom_initialized = false;
        #endregion

        #endregion ���ֶ�
        
		#region �����������������ֵ���Լ��������ԵĲ��ַ���

        /// <summary>
        /// ʵ���� 
        /// </summary>
        /// <returns></returns>
        public override string TableName()
        {
            return "T_ejiCategory";
        }
        
        /// <summary>
        /// �����Զ�����������
        /// </summary>
        /// <returns></returns>
        public override void LoadAllAttributes(bool IsLoadAllAttributes)
        {
            base.LoadAllAttributes(IsLoadAllAttributes);
            this.id_initialized = IsLoadAllAttributes;this.pid_initialized = IsLoadAllAttributes;this.ejiname_initialized = IsLoadAllAttributes;this.isshow_initialized = IsLoadAllAttributes;this.icom_initialized = IsLoadAllAttributes;
        }
        /// <summary></summary>
        public override ITable af_GetOptionValueSchema() 
		{ 
			T_ejiCategory value = new T_ejiCategory();
			
			
			if(BLLTable.IsExistOptionValue(this.TableName(),"Id"))
				value.id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Pid"))
				value.pid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Ejiname"))
				value.ejiname_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Isshow"))
				value.isshow_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Icom"))
				value.icom_initialized = true;
            
			return value;
		}
        #endregion
        
        #region ʵ��ICloneable ��Ա
        /// <summary></summary>
        public new T_ejiCategory Clone()
        {
            return (T_ejiCategory)this.MemberwiseClone(); //ǳ����
        }
        #endregion
        
        #region ���캯�� ���ʵ��
        /// <summary>���캯��  </summary>
        static T_ejiCategory()
        {
            //if (InitRunTime.IsInitRunTime) InitRunTime.IsInitRunTime = true;
        }
        /// <summary>���캯��  </summary>
        public T_ejiCategory() { }
        /// <summary>
        /// �Ƿ�������������  
        /// </summary>
        /// <param name="IsLoadAllAttributes">�Ƿ�ȫ����ʼ��Ϊtrue</param>
        public T_ejiCategory(bool IsLoadAllAttributes):base(IsLoadAllAttributes) { }
        /// <summary>ʵ�ֱַ��ܣ��޸ı���  </summary>
        //public T_ejiCategory(string tableName):base(tableName) { }
        /// <summary>ʵ�ֱַ��ܣ��Զ���ʵ���ĳ�ʼ��  </summary>
        //public T_ejiCategory(string tableName, params AttributeItem[] attrs) : base(tableName, attrs) { }
        /// <summary>ʵ�ֿ�ݹ���  </summary>
        //public T_ejiCategory(params AttributeItem[] attrs) : base(attrs) { }
        
        /// <summary>��ע�⣬���ﵱ���н�����һ���ֶε�ʱ�򣬽������빹�캯�� new Table(string tableName)��ͻ  </summary>
        public T_ejiCategory(int id1, string pid1, string ejiname1, bool isshow1, string icom1)
        {
            
            this.Id = id1;
            
            this.Pid = pid1;
            
            this.Ejiname = ejiname1;
            
            this.Isshow = isshow1;
            
            this.Icom = icom1;
        }
        /// <summary>����ͼ������ڻ�ȡ����  </summary>
        public static T_ejiCategory FromIView(IView view)
        {
            return (T_ejiCategory)IView.GetITable(view, "T_ejiCategory");
        }
        /// <summary>���һ��ʵ��  </summary>
        public static T_ejiCategory GetOneInstance()
        {
            T_ejiCategory value = new T_ejiCategory();
            return value;
        }
        /// <summary>��ȡ��һʵ��==BLLTable.GetRowData(); </summary>
        public T_ejiCategory Retrieve()
        {
            BLLTable<T_ejiCategory>.GetRowData(this);
            return this;
        }
        #endregion
		
        #region 2.2 �����������Բ�������

        /// <summary>ͨ������ ����ֶ�ֵ</summary>
        public override object GetValue(AttributeItem AttributeName)
        {	
            switch(AttributeName.FieldName)
			{				
			    case "Id":
			        return Id;
			    			
			    case "Pid":
			        return Pid;
			    			
			    case "Ejiname":
			        return Ejiname;
			    			
			    case "Isshow":
			        return Isshow;
			    			
			    case "Icom":
			        return Icom;
			
                default:
                    return base.GetValue(AttributeName);
			}
        }
        /// <summary>ͨ������ �����ֶ�ֵ</summary>
        public override bool SetValue(AttributeItem AttributeName,object AttributeValue)
        {
			switch(AttributeName.FieldName)
			{				
			    case "Id":
			        this.Id = Convert.ToInt32(AttributeValue);
                    return true;
			    			
			    case "Pid":
			        this.Pid = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Ejiname":
			        this.Ejiname = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Isshow":
			        this.Isshow = Convert.ToBoolean(AttributeValue);
                    return true;
			    			
			    case "Icom":
			        this.Icom = Convert.ToString(AttributeValue);
                    return true;
			
                default:
                    return base.SetValue(AttributeName, AttributeValue);
			}
        }
        
        /// <summary>ͨ������ ��ȡ���ֶ��Ƿ��ѱ���ʼ��</summary>
        public override bool GetInitialized(AttributeItem AttributeName)
        {
			switch(AttributeName.FieldName)
			{	
				case "Id":
					return id_initialized;
				
				case "Pid":
					return pid_initialized;
				
				case "Ejiname":
					return ejiname_initialized;
				
				case "Isshow":
					return isshow_initialized;
				
				case "Icom":
					return icom_initialized;
				
                default:
                    return base.GetInitialized(AttributeName);
			}
        }

        /// <summary>ͨ������ �������Եĳ�ʼ������ֵ</summary>
        public override bool SetInitialized(AttributeItem AttributeName, Boolean ret)
        {
			switch(AttributeName.FieldName)
			{	
				case "Id":
					id_initialized = ret;
					return true;
				
				case "Pid":
					pid_initialized = ret;
					return true;
				
				case "Ejiname":
					ejiname_initialized = ret;
					return true;
				
				case "Isshow":
					isshow_initialized = ret;
					return true;
				
				case "Icom":
					icom_initialized = ret;
					return true;
				
                default:
                    return base.SetInitialized(AttributeName, ret);
			}
        }
        #endregion

        #region ��ȡDataParameter PropertyInfo

        /// <summary>
        /// ��ȡ���б���ʼ������ֵ����ȡAttributeItem
        /// Ŀ��Ϊ��ȡ System.Windows.Forms.DataGridViewTextBoxColumn[] ���м����ݲ������ �Զ���� MyDataGridViewTextBoxColumn (����̳��� DataGridViewTextBoxColumn)
        /// ������������α����ķ�������Ϊ�˱����װ���̣�ʹ��Դ����ģʽ��ʱ�򣬲���������windows.form.dll��
        /// </summary>
        /// <returns></returns>
        public override AttributeItem[] af_GetAvailableAttributeItem(ref List<object> values)
        {
            List<AttributeItem> parametersList = new List<AttributeItem>();

			
			if (id_initialized)
			{
                AttributeItem attr = T_ejiCategory.Attribute.Id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Id);
                }
			}
			
			if (pid_initialized)
			{
                AttributeItem attr = T_ejiCategory.Attribute.Pid;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Pid);
                }
			}
			
			if (ejiname_initialized)
			{
                AttributeItem attr = T_ejiCategory.Attribute.Ejiname;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Ejiname);
                }
			}
			
			if (isshow_initialized)
			{
                AttributeItem attr = T_ejiCategory.Attribute.Isshow;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Isshow);
                }
			}
			
			if (icom_initialized)
			{
                AttributeItem attr = T_ejiCategory.Attribute.Icom;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Icom);
                }
			}
			
            
			parametersList.AddRange(base.af_GetAvailableAttributeItem(ref values));
            return parametersList.ToArray();
        }
        #endregion                

        #region Json����
        /// <summary>
        /// {�ֶ�����-�ṹ����}
        /// </summary>
        [Serializable]
        public class T_ejiCategoryJson
        {
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public int Id { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Pid { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Ejiname { get; set; }
            
            /// <summary>[CtrlTypeDic-{CheckBoxList}]</summary>
            public bool Isshow { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Icom { get; set; }
        }
        #endregion
    }
}