using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NH02
{
    public partial class Member
    {

        #region Extensibility Method Definitions

        /// <summary>
        /// There are no comments for OnCreated in the schema.
        /// </summary>
        partial void OnCreated();

        #endregion
        /// <summary>
        /// There are no comments for Member constructor in the schema.
        /// </summary>
        public Member()
        {
            OnCreated();
        }


        /// <summary>
        /// There are no comments for Id in the schema.
        /// </summary>
        public virtual int Id
        {
            get;
            set;
        }


        /// <summary>
        /// There are no comments for Name in the schema.
        /// </summary>
        public virtual string Name
        {
            get;
            set;
        }


        /// <summary>
        /// There are no comments for Password in the schema.
        /// </summary>
        public virtual string Password
        {
            get;
            set;
        }


        /// <summary>
        /// There are no comments for CreateTime in the schema.
        /// </summary>
        public virtual System.DateTime CreateTime
        {
            get;
            set;
        }


        /// <summary>
        /// There are no comments for Del in the schema.
        /// </summary>
        public virtual bool Del
        {
            get;
            set;
        }


        /// <summary>
        /// There are no comments for Mobile in the schema.
        /// </summary>
        public virtual string Mobile
        {
            get;
            set;
        }


        /// <summary>
        /// There are no comments for Email in the schema.
        /// </summary>
        public virtual string Email
        {
            get;
            set;
        }


        /// <summary>
        /// There are no comments for RealName in the schema.
        /// </summary>
        public virtual string RealName
        {
            get;
            set;
        }


        /// <summary>
        /// There are no comments for IDCard in the schema.
        /// </summary>
        public virtual string IDCard
        {
            get;
            set;
        }
    }
}
