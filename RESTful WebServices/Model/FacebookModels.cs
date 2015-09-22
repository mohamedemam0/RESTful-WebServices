using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RESTful_WebServices.Model
{
    public class Rootobject
    {
        public Datum[] data { get; set; }
        public Paging paging { get; set; }
    }

    public class Paging
    {
        public string previous { get; set; }
        public string next { get; set; }
    }

    public class Datum
    {
        public string id { get; set; }
        public From from { get; set; }
        public string message { get; set; }
        public string picture { get; set; }
        public string link { get; set; }
        public string icon { get; set; }
        public Action[] actions { get; set; }
        public Privacy privacy { get; set; }
        public string type { get; set; }
        public string status_type { get; set; }
        public string object_id { get; set; }
        public DateTime created_time { get; set; }
        public DateTime updated_time { get; set; }
        public Shares shares { get; set; }
        public bool is_hidden { get; set; }
        public bool is_expired { get; set; }
        public Likes likes { get; set; }
        public Comments comments { get; set; }
        public string caption { get; set; }
        public Story_Tags story_tags { get; set; }
        public string source { get; set; }
        public string name { get; set; }
        public Property1[] properties { get; set; }
    }

    public class From
    {
        public string name { get; set; }
        public string category { get; set; }
        public string id { get; set; }
    }

    public class Privacy
    {
        public string value { get; set; }
        public string description { get; set; }
        public string friends { get; set; }
        public string allow { get; set; }
        public string deny { get; set; }
    }

    public class Shares
    {
        public int count { get; set; }
    }

    public class Likes
    {
        public Datum1[] data { get; set; }
        public Paging1 paging { get; set; }
    }

    public class Paging1
    {
        public Cursors cursors { get; set; }
        public string next { get; set; }
    }

    public class Cursors
    {
        public string after { get; set; }
        public string before { get; set; }
    }

    public class Datum1
    {
        public string id { get; set; }
        public string name { get; set; }
    }

    public class Comments
    {
        public Datum2[] data { get; set; }
        public Paging2 paging { get; set; }
    }

    public class Paging2
    {
        public Cursors1 cursors { get; set; }
        public string next { get; set; }
    }

    public class Cursors1
    {
        public string after { get; set; }
        public string before { get; set; }
    }

    public class Datum2
    {
        public string id { get; set; }
        public From1 from { get; set; }
        public string message { get; set; }
        public bool can_remove { get; set; }
        public DateTime created_time { get; set; }
        public int like_count { get; set; }
        public bool user_likes { get; set; }
        public Message_Tags[] message_tags { get; set; }
    }

    public class From1
    {
        public string name { get; set; }
        public string id { get; set; }
        public string category { get; set; }
    }

    public class Message_Tags
    {
        public string id { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public int offset { get; set; }
        public int length { get; set; }
    }

    public class Story_Tags
    {
        public _0[] _0 { get; set; }
        public _46[] _46 { get; set; }
    }

    public class _0
    {
        public string id { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public int offset { get; set; }
        public int length { get; set; }
    }

    public class _46
    {
        public string id { get; set; }
        public string name { get; set; }
        public int offset { get; set; }
        public int length { get; set; }
    }

    public class Action
    {
        public string name { get; set; }
        public string link { get; set; }
    }

    public class Property1
    {
        public string name { get; set; }
        public string text { get; set; }
    }

}
