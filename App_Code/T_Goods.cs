/************************************************************

  Copyright (c) 2008��ybkj_zlg
  Author:               Created Time: 2016/12/20 19:33:27
  Description:    ���ݱ�T_Goods��Ӧ��ҵ���߼���T_Goods
  Version:         2.1.0.0
  * �Դ��ļ��ĸ��Ŀ��ܻᵼ�²���ȷ����Ϊ���������
     �������ɴ��룬��Щ���Ľ��ᶪʧ����������չ����
 * ʵ���Լ��� T_Goods_Entity:T_Goods
 * 
************************************************************/
/************************************************************
SQL���룺
select Id,EjiPid,GoodName,GoodContent,Isshow,Price,PriceIncludeCarriage from T_Goods
delete from T_Goods
INSERT INTO T_Goods (Id,EjiPid,GoodName,GoodContent,Isshow,Price,PriceIncludeCarriage)
     VALUES
           ('','','','','','','')
UPDATE T_Goods SET ...
������ֵ���룺
 *         valObj.Id = valObj2.Id;
        valObj.EjiPid = valObj2.EjiPid;
        valObj.GoodName = valObj2.GoodName;
        valObj.GoodContent = valObj2.GoodContent;
        valObj.Isshow = valObj2.Isshow;
        valObj.Price = valObj2.Price;
        valObj.PriceIncludeCarriage = valObj2.PriceIncludeCarriage; 
        valObj.Id = "";
        valObj.EjiPid = "";
        valObj.GoodName = "";
        valObj.GoodContent = "";
        valObj.Isshow = "";
        valObj.Price = "";
        valObj.PriceIncludeCarriage = ""; 
        "Id": $("#txt_Id").val(),
        "EjiPid": $("#txt_EjiPid").val(),
        "GoodName": $("#txt_GoodName").val(),
        "GoodContent": $("#txt_GoodContent").val(),
        "Isshow": $("#txt_Isshow").val(),
        "Price": $("#txt_Price").val(),
        "PriceIncludeCarriage": $("#txt_PriceIncludeCarriage").val(), 
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
    /// <para>��T_Goods���ݱ��Ӧ��ʵ�����</para>
    /// <para>����һ�������еķ����ǣ���"���ֶ�"������һ��bool��ʶλ����"Attribute"���� </para>
    /// </summary>    
    [Serializable]
    public class T_Goods : ITableImplement
    {
        /// <summary>��������  </summary>
        public static T_Goods Factory()
        {
            return new T_Goods();
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
        public string _EjiPid
        {            
            get { return this.EjiPid; }
            set { this.EjiPid = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _GoodName
        {            
            get { return this.GoodName; }
            set { this.GoodName = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _GoodContent
        {            
            get { return this.GoodContent; }
            set { this.GoodContent = value; }
        }
        
        /// <summary> [CtrlTypeDic-{CheckBoxList}] Attribute </summary>
        public bool _Isshow
        {            
            get { return this.Isshow; }
            set { this.Isshow = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _Price
        {            
            get { return this.Price; }
            set { this.Price = value; }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}] Attribute_IsNotNull </summary>
        public string _PriceIncludeCarriage
        {            
            get { return this.PriceIncludeCarriage; }
            set { this.PriceIncludeCarriage = value; }
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
        public string EjiPid
        {
            get { return this.m_ejipid; }
            set //
            {
                if (!ejipid_initialized || m_ejipid != value)
                {
                    this.m_ejipid = value;
                }
                ejipid_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string GoodName
        {
            get { return this.m_goodname; }
            set //
            {
                if (!goodname_initialized || m_goodname != value)
                {
                    this.m_goodname = value;
                }
                goodname_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string GoodContent
        {
            get { return this.m_goodcontent; }
            set //
            {
                if (!goodcontent_initialized || m_goodcontent != value)
                {
                    this.m_goodcontent = value;
                }
                goodcontent_initialized = true;
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
        public string Price
        {
            get { return this.m_price; }
            set //
            {
                if (!price_initialized || m_price != value)
                {
                    this.m_price = value;
                }
                price_initialized = true;
            }
        }
        
        /// <summary> [CtrlTypeDic-{InputString}]���Ƽ�ʹ�� "_"���ſ�ͷ </summary>
        public string PriceIncludeCarriage
        {
            get { return this.m_priceincludecarriage; }
            set //
            {
                if (!priceincludecarriage_initialized || m_priceincludecarriage != value)
                {
                    this.m_priceincludecarriage = value;
                }
                priceincludecarriage_initialized = true;
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
            public static AttributeItem Id =  new AttributeItem("[T_Goods].[Id]", typeof(int), 4);
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem EjiPid =  new AttributeItem("[T_Goods].[EjiPid]", typeof(string), 50);
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem GoodName =  new AttributeItem("[T_Goods].[GoodName]", typeof(string), 50);
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem GoodContent =  new AttributeItem("[T_Goods].[GoodContent]", typeof(string), 250);
            
            /// <summary>[CtrlTypeDic-{CheckBoxList}]</summary>
            public static AttributeItem Isshow =  new AttributeItem("[T_Goods].[Isshow]", typeof(bool), 1);
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem Price =  new AttributeItem("[T_Goods].[Price]", typeof(string), 50);
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public static AttributeItem PriceIncludeCarriage =  new AttributeItem("[T_Goods].[PriceIncludeCarriage]", typeof(string), 50);
        }
        #endregion
        #region bool�嵥 �������
        
        private int m_id;
        /// <summary></summary>
        protected bool id_initialized = false;
        
        private string m_ejipid;
        /// <summary></summary>
        protected bool ejipid_initialized = false;
        
        private string m_goodname;
        /// <summary></summary>
        protected bool goodname_initialized = false;
        
        private string m_goodcontent;
        /// <summary></summary>
        protected bool goodcontent_initialized = false;
        
        private bool m_isshow;
        /// <summary></summary>
        protected bool isshow_initialized = false;
        
        private string m_price;
        /// <summary></summary>
        protected bool price_initialized = false;
        
        private string m_priceincludecarriage;
        /// <summary></summary>
        protected bool priceincludecarriage_initialized = false;
        #endregion

        #endregion ���ֶ�
        
		#region �����������������ֵ���Լ��������ԵĲ��ַ���

        /// <summary>
        /// ʵ���� 
        /// </summary>
        /// <returns></returns>
        public override string TableName()
        {
            return "T_Goods";
        }
        
        /// <summary>
        /// �����Զ�����������
        /// </summary>
        /// <returns></returns>
        public override void LoadAllAttributes(bool IsLoadAllAttributes)
        {
            base.LoadAllAttributes(IsLoadAllAttributes);
            this.id_initialized = IsLoadAllAttributes;this.ejipid_initialized = IsLoadAllAttributes;this.goodname_initialized = IsLoadAllAttributes;this.goodcontent_initialized = IsLoadAllAttributes;this.isshow_initialized = IsLoadAllAttributes;this.price_initialized = IsLoadAllAttributes;this.priceincludecarriage_initialized = IsLoadAllAttributes;
        }
        /// <summary></summary>
        public override ITable af_GetOptionValueSchema() 
		{ 
			T_Goods value = new T_Goods();
			
			
			if(BLLTable.IsExistOptionValue(this.TableName(),"Id"))
				value.id_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"EjiPid"))
				value.ejipid_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"GoodName"))
				value.goodname_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"GoodContent"))
				value.goodcontent_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Isshow"))
				value.isshow_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"Price"))
				value.price_initialized = true;
            
			if(BLLTable.IsExistOptionValue(this.TableName(),"PriceIncludeCarriage"))
				value.priceincludecarriage_initialized = true;
            
			return value;
		}
        #endregion
        
        #region ʵ��ICloneable ��Ա
        /// <summary></summary>
        public new T_Goods Clone()
        {
            return (T_Goods)this.MemberwiseClone(); //ǳ����
        }
        #endregion
        
        #region ���캯�� ���ʵ��
        /// <summary>���캯��  </summary>
        static T_Goods()
        {
            //if (InitRunTime.IsInitRunTime) InitRunTime.IsInitRunTime = true;
        }
        /// <summary>���캯��  </summary>
        public T_Goods() { }
        /// <summary>
        /// �Ƿ�������������  
        /// </summary>
        /// <param name="IsLoadAllAttributes">�Ƿ�ȫ����ʼ��Ϊtrue</param>
        public T_Goods(bool IsLoadAllAttributes):base(IsLoadAllAttributes) { }
        /// <summary>ʵ�ֱַ��ܣ��޸ı���  </summary>
        //public T_Goods(string tableName):base(tableName) { }
        /// <summary>ʵ�ֱַ��ܣ��Զ���ʵ���ĳ�ʼ��  </summary>
        //public T_Goods(string tableName, params AttributeItem[] attrs) : base(tableName, attrs) { }
        /// <summary>ʵ�ֿ�ݹ���  </summary>
        //public T_Goods(params AttributeItem[] attrs) : base(attrs) { }
        
        /// <summary>��ע�⣬���ﵱ���н�����һ���ֶε�ʱ�򣬽������빹�캯�� new Table(string tableName)��ͻ  </summary>
        public T_Goods(int id1, string ejipid1, string goodname1, string goodcontent1, bool isshow1, string price1, string priceincludecarriage1)
        {
            
            this.Id = id1;
            
            this.EjiPid = ejipid1;
            
            this.GoodName = goodname1;
            
            this.GoodContent = goodcontent1;
            
            this.Isshow = isshow1;
            
            this.Price = price1;
            
            this.PriceIncludeCarriage = priceincludecarriage1;
        }
        /// <summary>����ͼ������ڻ�ȡ����  </summary>
        public static T_Goods FromIView(IView view)
        {
            return (T_Goods)IView.GetITable(view, "T_Goods");
        }
        /// <summary>���һ��ʵ��  </summary>
        public static T_Goods GetOneInstance()
        {
            T_Goods value = new T_Goods();
            return value;
        }
        /// <summary>��ȡ��һʵ��==BLLTable.GetRowData(); </summary>
        public T_Goods Retrieve()
        {
            BLLTable<T_Goods>.GetRowData(this);
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
			    			
			    case "EjiPid":
			        return EjiPid;
			    			
			    case "GoodName":
			        return GoodName;
			    			
			    case "GoodContent":
			        return GoodContent;
			    			
			    case "Isshow":
			        return Isshow;
			    			
			    case "Price":
			        return Price;
			    			
			    case "PriceIncludeCarriage":
			        return PriceIncludeCarriage;
			
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
			    			
			    case "EjiPid":
			        this.EjiPid = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "GoodName":
			        this.GoodName = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "GoodContent":
			        this.GoodContent = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "Isshow":
			        this.Isshow = Convert.ToBoolean(AttributeValue);
                    return true;
			    			
			    case "Price":
			        this.Price = Convert.ToString(AttributeValue);
                    return true;
			    			
			    case "PriceIncludeCarriage":
			        this.PriceIncludeCarriage = Convert.ToString(AttributeValue);
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
				
				case "EjiPid":
					return ejipid_initialized;
				
				case "GoodName":
					return goodname_initialized;
				
				case "GoodContent":
					return goodcontent_initialized;
				
				case "Isshow":
					return isshow_initialized;
				
				case "Price":
					return price_initialized;
				
				case "PriceIncludeCarriage":
					return priceincludecarriage_initialized;
				
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
				
				case "EjiPid":
					ejipid_initialized = ret;
					return true;
				
				case "GoodName":
					goodname_initialized = ret;
					return true;
				
				case "GoodContent":
					goodcontent_initialized = ret;
					return true;
				
				case "Isshow":
					isshow_initialized = ret;
					return true;
				
				case "Price":
					price_initialized = ret;
					return true;
				
				case "PriceIncludeCarriage":
					priceincludecarriage_initialized = ret;
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
                AttributeItem attr = T_Goods.Attribute.Id;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Id);
                }
			}
			
			if (ejipid_initialized)
			{
                AttributeItem attr = T_Goods.Attribute.EjiPid;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(EjiPid);
                }
			}
			
			if (goodname_initialized)
			{
                AttributeItem attr = T_Goods.Attribute.GoodName;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(GoodName);
                }
			}
			
			if (goodcontent_initialized)
			{
                AttributeItem attr = T_Goods.Attribute.GoodContent;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(GoodContent);
                }
			}
			
			if (isshow_initialized)
			{
                AttributeItem attr = T_Goods.Attribute.Isshow;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Isshow);
                }
			}
			
			if (price_initialized)
			{
                AttributeItem attr = T_Goods.Attribute.Price;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(Price);
                }
			}
			
			if (priceincludecarriage_initialized)
			{
                AttributeItem attr = T_Goods.Attribute.PriceIncludeCarriage;
                if(!af_IsCondition || !Runtime_PersistenceLayer.IsInTbColumnCannotConditions(attr))
                {
                    parametersList.Add(attr);
                    if(values != null)
                        values.Add(PriceIncludeCarriage);
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
        public class T_GoodsJson
        {
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public int Id { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string EjiPid { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string GoodName { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string GoodContent { get; set; }
            
            /// <summary>[CtrlTypeDic-{CheckBoxList}]</summary>
            public bool Isshow { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string Price { get; set; }
            
            /// <summary>[CtrlTypeDic-{InputString}]</summary>
            public string PriceIncludeCarriage { get; set; }
        }
        #endregion
    }
}