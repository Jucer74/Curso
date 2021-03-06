﻿using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace PnP.Patterns.Singleton.XmlData
{
    [Serializable()]
    public class Messages
    {

        private List<MessageData> items;

        /// <remarks/>
        [XmlElementAttribute("MessageData")]
        public List<MessageData> Items
        {
            get
            {
                return this.items;
            }
            set
            {
                this.items = value;
            }
        }
    }

    /// <remarks/>
    [Serializable()]
    public class MessageData
    {

        private string id;

        private string type;

        private string description;

        /// <remarks/>
        [XmlElementAttribute()]
        public string Id
        {
            get
            {
                return this.id;
            }
            set
            {
                this.id = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute()]
        public string Type
        {
            get
            {
                return this.type;
            }
            set
            {
                this.type = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute()]
        public string Description
        {
            get
            {
                return this.description;
            }
            set
            {
                this.description = value;
            }
        }
    }
}