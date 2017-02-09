/************************************************************

  Copyright (c) 2008��ybkj_zlg
  Author:               Created Time: 2016/12/20 19:33:27
  Description:    ���ݱ�T_Goods_Category��Ӧ��ҵ���߼���T_Goods_Category
  Version:         2.1.0.0
  * �Դ��ļ��ĸ��Ŀ��ܻᵼ�²���ȷ����Ϊ���������
     �������ɴ��룬��Щ���Ľ��ᶪʧ����������չ����
 * ʵ���Լ��� T_Goods_Category_Entity:T_Goods_Category
 * 
************************************************************/
/************************************************************
SQL���룺
select Id,Goods_Id,Category_Id,Pid from T_Goods_Category
delete from T_Goods_Category
INSERT INTO T_Goods_Category (Id,Goods_Id,Category_Id,Pid)
     VALUES
           ('','','','')
UPDATE T_Goods_Category SET ...
������ֵ���룺
 *         valObj.Id = valObj2.Id;
        valObj.Goods_Id = valObj2.Goods_Id;
        valObj.Category_Id = valObj2.Category_Id;
        valObj.Pid = valObj2.Pid; 
        valObj.Id = "";
        valObj.Goods_Id = "";
        valObj.Category_Id = "";
        valObj.Pid = ""; 
        "Id": $("#txt_Id").val(),
        "Goods_Id": $("#txt_Goods_Id").val(),
        "Category_Id": $("#txt_Category_Id").val(),
        "Pid": $("#txt_Pid").val(), 
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
    /// <para>��Ʒ�����</para>
    /// <para>��T_Goods_Category���ݱ��Ӧ��ʵ�����</para>
    /// <para>����һ�������еķ����ǣ���"���ֶ�"������һ��bool��ʶλ����"Attribute"���� </para>
    /// </summary>    
    [Serializable]
    public class T_Goods_Category : ITableImplement
    {
        /// <summary>��������  </summary>
        public static T_Goods_Category Factory()
        {
            return new T_Goods_Category();
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
        public string _Goods_Id
        {            
            get { return this.Goods_Id; }
            set { this.Goods_Id = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Category_Id
        {            
            get { return this.Category_Id; }
            set { this.Category_Id = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Pid
        {            
            get { return this.Pid; }
            set { this.Pid = value; }
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
        public string Goods_Id
        {
            get { return this.m_goods_id; }
            set //
            {
                if (!goods_id_initialized || m_goods_id != value)
                {
                    this.m_goods_id = value;
                }
                goods_id_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string Category_Id
        {
            get { return this.m_category_id; }
            set //
            {
                if (!category_id_initialized || m_category_id != value)
                {
                    this.m_category_id = value;
                }
                category_id_initialized = true;
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
        #endregion
        #region Attribute�嵥 �������
        /// <summary>
        /// {�ֶ�����-�ṹ����}
        /// </summary>
        public class Attribute
        {
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Id =  new AttributeItem("[T_Goods_Category].[Id]", typeof(int), 4);
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Goods_Id =  new AttributeItem("[T_Goods_Category].[Goods_Id]", typeof(string), 50);
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Category_Id =  new AttributeItem("[T_Goods_Category].[Category_Id]", typeof(string), 50);
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Pid =  new AttributeItem("[T_Goods_Category].[Pid]", typeof(string), 50);
        }
        #endregion
        #region bool�嵥 �������
        
        private int m_id;
        /// <summary></summary>
        protected bool id_initialized = false;
        
        private string m_goods_id;
        /// <summary></summary>
        protected bool goods_id_initialized = false;
        
        private string m_category_id;
        /// <summary></summary>
        protected bool category_id_initialized = false;
        
        private string m_pid;
        /// <summary></summary>
        protected bool pid_initialized = false;
        #endregion

        #endregion ���ֶ�
        
		#region �����������������ֵ���Լ��������ԵĲ��ַ���

        /// <summary>
        /// ʵ���� 
        /// </summary>
        /// <returns></returns>
        public override string TableName()
        {
            return "T_Goods_Category";
        }
        
        /// <summary>
        /// �����Զ�����������
        /// </summary>
        /// <returns></returns>
        public override void LoadAllAttributes(bool IsLoadAllAttributes)
        {
            base.LoadAllAttributes(IsLoadAllAttributes);
            this.id_initialized = IsLoadAllAttributes;this.goods_id_initialized = IsLoadAllAttributes;this.category_id_initialized = IsLoadAllAttributes;this.pid_initialized = IsLoadAllAttributes;
        }
        /// <summary></summary>
        public override ITable af_GetOptionValueSchema() 
		{ 
			T_Goods_Category value = new T_Goods_Category();
			
			
			if(BLLTable.IsExistOptionValue(this.TableName(),"Id"))
				value.id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Goods_Id"))
				value.goods_id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Category_Id"))
				value.category_id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Pid"))
				value.pid_initialized = true;
            
			return value;
		}
        #endregion
        
        #region ʵ��ICloneable ��Ա
        /// <summary></summary>
        public new T_Goods_Category Clone()
        {
            return (T_Goods_Category)this.MemberwiseClone(); //ǳ����
        }
        #endregion
        
        #region ���캯�� ���ʵ��
        /// <summary>���캯��  </summary>
        static T_Goods_Category()
        {
            //if (InitRunTime.IsInitRunTime) InitRunTime.IsInitRunTime = true;
        }
        /// <summary>���캯��  </summary>
        public T_Goods_Category() { }
        /// <summary>
        /// �Ƿ�������������  
        /// </summary>
        /// <param name="IsLoadAllAttributes">�Ƿ�ȫ����ʼ��Ϊtrue</param>
        public T_Goods_Category(bool IsLoadAllAttributes):base(IsLoadAllAttributes) { }
        /// <summary>ʵ�ֱַ��ܣ��޸ı���  </summary>
        //public T_Goods_Category(string tableName):base(tableName) { }
        /// <summary>ʵ�ֱַ��ܣ��Զ���ʵ���ĳ�ʼ��  </summary>
        //public T_Goods_Category(string tableName, params AttributeItem[] attrs) : base(tableName, attrs) { }
        /// <summary>ʵ�ֿ�ݹ���  </summary>
        //public T_Goods_Category(params AttributeItem[] attrs) : base(attrs) { }
        
        /// <summary>��ע�⣬���ﵱ���н�����һ���ֶε�ʱ�򣬽������빹�캯�� new Table(string tableName)��ͻ  </summary>
        public T_Goods_Category(int id1, string goods_id1, string category_id1, string pid1)
        {
            
            this.Id = id1;
            
            this.Goods_Id = goods_id1;
            
            this.Category_Id = category_id1;
            
            this.Pid = pid1;
        }
        /// <summary>����ͼ������ڻ�ȡ����  </summary>
        public static T_Goods_Category FromIView(IView view)
        {
            return (T_Goods_Category)IView.GetITable(view, "T_Goods_Category");
        }
        /// <summary>���һ��ʵ��  </summary>
        public static T_Goods_Category GetOneInstance()
        {
            T_Goods_Category value = new T_Goods_Category();
            return value;
        }
        /// <summary>��ȡ��һʵ��==BLLTable.GetRowData(); </summary>
        public T_Goods_Category Retrieve()
        {
            BLLTable<T_Goods_Category>.GetRowData(this);
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
			    			
			    case "Goods_Id":
			        return Goods_Id;
			    			
			    case "Category_Id":
			        return Category_Id;
			    			
			    case "Pid":
			        return Pid;
			
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
			    			
			    case "Goods_Id":
			        this.Goods_Id = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Category_Id":
			        this.Category_Id = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Pid":
			        this.Pid = Convert.ToString(AttributeValue);
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
				
				case "Goods_Id":
					return goods_id_initialized;
				
				case "Category_Id":
					return category_id_initialized;
				
				case "Pid":
					return pid_initialized;
				
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
				
				case "Goods_Id":
					goods_id_initialized = ret;
					return true;
				
				case "Category_Id":
					category_id_initialized = ret;
					return true;
				
				case "Pid":
					pid_initialized = ret;
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
                AttributeItem attr = T_Goods_Category.Attribute.Id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Id);
                }
			}
			
			if (goods_id_initialized)
			{
                AttributeItem attr = T_Goods_Category.Attribute.Goods_Id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Goods_Id);
                }
			}
			
			if (category_id_initialized)
			{
                AttributeItem attr = T_Goods_Category.Attribute.Category_Id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Category_Id);
                }
			}
			
			if (pid_initialized)
			{
                AttributeItem attr = T_Goods_Category.Attribute.Pid;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Pid);
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
        public class T_Goods_CategoryJson
        {
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public int Id { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Goods_Id { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Category_Id { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Pid { get; set; }
        }
        #endregion
    }
}