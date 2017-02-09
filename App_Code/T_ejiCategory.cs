/************************************************************

  Copyright (c) 2008，ybkj_zlg
  Author:               Created Time: 2016/12/20 19:33:27
  Description:    数据表T_ejiCategory对应的业务逻辑层T_ejiCategory
  Version:         2.1.0.0
  * 对此文件的更改可能会导致不正确的行为，并且如果
     重新生成代码，这些更改将会丢失。您可以扩展该类
 * 实现自己的 T_ejiCategory_Entity:T_ejiCategory
 * 
************************************************************/
/************************************************************
SQL代码：
select Id,Pid,Ejiname,Isshow,Icom from T_ejiCategory
delete from T_ejiCategory
INSERT INTO T_ejiCategory (Id,Pid,Ejiname,Isshow,Icom)
     VALUES
           ('','','','','')
UPDATE T_ejiCategory SET ...
变量赋值代码：
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
    /// <para>与T_ejiCategory数据表对应的实体对象。</para>
    /// <para>增加一个数据列的方法是：在"类字段"节增加一个bool标识位，与"Attribute"属性 </para>
    /// </summary>    
    [Serializable]
    public class T_ejiCategory : ITableImplement
    {
        /// <summary>工厂方法  </summary>
        public static T_ejiCategory Factory()
        {
            return new T_ejiCategory();
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
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
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
        
        /// <summary> [CtrlTypeDic-{CheckBoxList}]，推荐使用 "_"符号开头 </summary>
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
        
        /// <summary> [CtrlTypeDic-{InputString}]，推荐使用 "_"符号开头 </summary>
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
        #region Attribute清单 辅助设计
        /// <summary>
        /// {字段属性-结构属性}
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
        #region bool清单 辅助设计
        
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

        #endregion 类字段
        
		#region 获得与设置属性列与值，以及操作属性的部分方法

        /// <summary>
        /// 实体名 
        /// </summary>
        /// <returns></returns>
        public override string TableName()
        {
            return "T_ejiCategory";
        }
        
        /// <summary>
        /// 设置自动载入所有列
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
        
        #region 实现ICloneable 成员
        /// <summary></summary>
        public new T_ejiCategory Clone()
        {
            return (T_ejiCategory)this.MemberwiseClone(); //浅复制
        }
        #endregion
        
        #region 构造函数 获得实例
        /// <summary>构造函数  </summary>
        static T_ejiCategory()
        {
            //if (InitRunTime.IsInitRunTime) InitRunTime.IsInitRunTime = true;
        }
        /// <summary>构造函数  </summary>
        public T_ejiCategory() { }
        /// <summary>
        /// 是否载入所有属性  
        /// </summary>
        /// <param name="IsLoadAllAttributes">是否全部初始化为true</param>
        public T_ejiCategory(bool IsLoadAllAttributes):base(IsLoadAllAttributes) { }
        /// <summary>实现分表功能，修改表名  </summary>
        //public T_ejiCategory(string tableName):base(tableName) { }
        /// <summary>实现分表功能，自定义实例的初始化  </summary>
        //public T_ejiCategory(string tableName, params AttributeItem[] attrs) : base(tableName, attrs) { }
        /// <summary>实现快捷功能  </summary>
        //public T_ejiCategory(params AttributeItem[] attrs) : base(attrs) { }
        
        /// <summary>请注意，这里当表中仅存在一个字段的时候，将可能与构造函数 new Table(string tableName)冲突  </summary>
        public T_ejiCategory(int id1, string pid1, string ejiname1, bool isshow1, string icom1)
        {
            
            this.Id = id1;
            
            this.Pid = pid1;
            
            this.Ejiname = ejiname1;
            
            this.Isshow = isshow1;
            
            this.Icom = icom1;
        }
        /// <summary>从视图（多表）内获取本表  </summary>
        public static T_ejiCategory FromIView(IView view)
        {
            return (T_ejiCategory)IView.GetITable(view, "T_ejiCategory");
        }
        /// <summary>获得一个实例  </summary>
        public static T_ejiCategory GetOneInstance()
        {
            T_ejiCategory value = new T_ejiCategory();
            return value;
        }
        /// <summary>获取单一实例==BLLTable.GetRowData(); </summary>
        public T_ejiCategory Retrieve()
        {
            BLLTable<T_ejiCategory>.GetRowData(this);
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
        /// <summary>通过属性 设置字段值</summary>
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
        
        /// <summary>通过属性 获取该字段是否已被初始化</summary>
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

        /// <summary>通过属性 设置属性的初始化布尔值</summary>
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

        #region Json对象
        /// <summary>
        /// {字段属性-结构属性}
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