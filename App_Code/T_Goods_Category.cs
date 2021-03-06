/************************************************************

  Copyright (c) 2008，ybkj_zlg
  Author:               Created Time: 2016/12/20 19:33:27
  Description:    数据表T_Goods_Category对应的业务逻辑层T_Goods_Category
  Version:         2.1.0.0
  * 对此文件的更改可能会导致不正确的行为，并且如果
     重新生成代码，这些更改将会丢失。您可以扩展该类
 * 实现自己的 T_Goods_Category_Entity:T_Goods_Category
 * 
************************************************************/
/************************************************************
SQL代码：
select Id,Goods_Id,Category_Id,Pid from T_Goods_Category
delete from T_Goods_Category
INSERT INTO T_Goods_Category (Id,Goods_Id,Category_Id,Pid)
     VALUES
           ('','','','')
UPDATE T_Goods_Category SET ...
变量赋值代码：
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
    /// <para>产品分类表</para>
    /// <para>与T_Goods_Category数据表对应的实体对象。</para>
    /// <para>增加一个数据列的方法是：在"类字段"节增加一个bool标识位，与"Attribute"属性 </para>
    /// </summary>    
    [Serializable]
    public class T_Goods_Category : ITableImplement
    {
        /// <summary>工厂方法  </summary>
        public static T_Goods_Category Factory()
        {
            return new T_Goods_Category();
        }
		#region 类字段清单 列属性用于生成视图层时的一致性检查
        #region 类字段清单1
        
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
        #region 类字段清单2
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
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
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
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
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
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
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
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
        #region Attribute清单 辅助设计
        /// <summary>
        /// {字段属性-结构属性}
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
        #region bool清单 辅助设计
        
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

        #endregion 类字段
        
		#region 获得与设置属性列与值，以及操作属性的部分方法

        /// <summary>
        /// 实体名 
        /// </summary>
        /// <returns></returns>
        public override string TableName()
        {
            return "T_Goods_Category";
        }
        
        /// <summary>
        /// 设置自动载入所有列
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
        
        #region 实现ICloneable 成员
        /// <summary></summary>
        public new T_Goods_Category Clone()
        {
            return (T_Goods_Category)this.MemberwiseClone(); //浅复制
        }
        #endregion
        
        #region 构造函数 获得实例
        /// <summary>构造函数  </summary>
        static T_Goods_Category()
        {
            //if (InitRunTime.IsInitRunTime) InitRunTime.IsInitRunTime = true;
        }
        /// <summary>构造函数  </summary>
        public T_Goods_Category() { }
        /// <summary>
        /// 是否载入所有属性  
        /// </summary>
        /// <param name="IsLoadAllAttributes">是否全部初始化为true</param>
        public T_Goods_Category(bool IsLoadAllAttributes):base(IsLoadAllAttributes) { }
        /// <summary>实现分表功能，修改表名  </summary>
        //public T_Goods_Category(string tableName):base(tableName) { }
        /// <summary>实现分表功能，自定义实例的初始化  </summary>
        //public T_Goods_Category(string tableName, params AttributeItem[] attrs) : base(tableName, attrs) { }
        /// <summary>实现快捷功能  </summary>
        //public T_Goods_Category(params AttributeItem[] attrs) : base(attrs) { }
        
        /// <summary>请注意，这里当表中仅存在一个字段的时候，将可能与构造函数 new Table(string tableName)冲突  </summary>
        public T_Goods_Category(int id1, string goods_id1, string category_id1, string pid1)
        {
            
            this.Id = id1;
            
            this.Goods_Id = goods_id1;
            
            this.Category_Id = category_id1;
            
            this.Pid = pid1;
        }
        /// <summary>从视图（多表）内获取本表  </summary>
        public static T_Goods_Category FromIView(IView view)
        {
            return (T_Goods_Category)IView.GetITable(view, "T_Goods_Category");
        }
        /// <summary>获得一个实例  </summary>
        public static T_Goods_Category GetOneInstance()
        {
            T_Goods_Category value = new T_Goods_Category();
            return value;
        }
        /// <summary>获取单一实例==BLLTable.GetRowData(); </summary>
        public T_Goods_Category Retrieve()
        {
            BLLTable<T_Goods_Category>.GetRowData(this);
            return this;
        }
        #endregion
		
        #region 2.2 新增的列属性操作方法

        /// <summary>通过属性 获得字段值</summary>
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
        /// <summary>通过属性 设置字段值</summary>
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
        
        /// <summary>通过属性 获取该字段是否已被初始化</summary>
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

        /// <summary>通过属性 设置属性的初始化布尔值</summary>
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

        #region 获取DataParameter PropertyInfo

        /// <summary>
        /// 获取所有被初始化过的值，获取AttributeItem
        /// 目的为获取 System.Windows.Forms.DataGridViewTextBoxColumn[] 在中间数据层采用了 自定义的 MyDataGridViewTextBoxColumn (空类继承自 DataGridViewTextBoxColumn)
        /// 这里采用了两次遍历的方法，是为了避免拆装过程，使用源代码模式的时候，不会依赖于windows.form.dll。
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

        #region Json对象
        /// <summary>
        /// {字段属性-结构属性}
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