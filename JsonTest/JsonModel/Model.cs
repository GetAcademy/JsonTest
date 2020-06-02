using System;
using System.Collections.Generic;
using System.Text;

namespace JsonTest.JsonModel
{

  public class IssuesResponse
  {
    public string expand { get; set; }
    public int startAt { get; set; }
    public int maxResults { get; set; }
    public int total { get; set; }
    public Issue[] issues { get; set; }
  }

  public class Issue
  {
    public string expand { get; set; }
    public string id { get; set; }
    public string self { get; set; }
    public string key { get; set; }
    public Fields fields { get; set; }
  }

  public class Fields
  {
    public DateTime statuscategorychangedate { get; set; }
    public object[] fixVersions { get; set; }
    public Resolution resolution { get; set; }
    public object customfield_12014 { get; set; }
    public object customfield_11841 { get; set; }
    public object customfield_11840 { get; set; }
    public object customfield_10500 { get; set; }
    public Customfield_12008 customfield_12008 { get; set; }
    public object customfield_11832 { get; set; }
    public object customfield_11831 { get; set; }
    public object customfield_11834 { get; set; }
    public object customfield_11833 { get; set; }
    public object customfield_11836 { get; set; }
    public object customfield_11835 { get; set; }
    public object customfield_11838 { get; set; }
    public object customfield_10903 { get; set; }
    public object customfield_11837 { get; set; }
    public object customfield_10904 { get; set; }
    public object customfield_11839 { get; set; }
    public object customfield_10906 { get; set; }
    public object customfield_10907 { get; set; }
    public object lastViewed { get; set; }
    public object customfield_12082 { get; set; }
    public object customfield_12084 { get; set; }
    public object customfield_12086 { get; set; }
    public object customfield_12085 { get; set; }
    public string customfield_12000 { get; set; }
    public object customfield_12087 { get; set; }
    public object customfield_12002 { get; set; }
    public object customfield_12001 { get; set; }
    public DateTime customfield_12004 { get; set; }
    public Priority priority { get; set; }
    public object customfield_12003 { get; set; }
    public object customfield_11830 { get; set; }
    public string customfield_12005 { get; set; }
    public object[] labels { get; set; }
    public object customfield_11700 { get; set; }
    public object customfield_11821 { get; set; }
    public object customfield_11820 { get; set; }
    public object customfield_11823 { get; set; }
    public object customfield_11701 { get; set; }
    public object customfield_11822 { get; set; }
    public object aggregatetimeoriginalestimate { get; set; }
    public object timeestimate { get; set; }
    public object customfield_11825 { get; set; }
    public object[] versions { get; set; }
    public object customfield_11824 { get; set; }
    public object customfield_11827 { get; set; }
    public object customfield_11826 { get; set; }
    public object customfield_11829 { get; set; }
    public object customfield_11828 { get; set; }
    public object[] issuelinks { get; set; }
    public Assignee assignee { get; set; }
    public Status status { get; set; }
    public object[] components { get; set; }
    public object customfield_12071 { get; set; }
    public object customfield_12070 { get; set; }
    public object customfield_12073 { get; set; }
    public object customfield_12072 { get; set; }
    public string customfield_12075 { get; set; }
    public Customfield_12074 customfield_12074 { get; set; }
    public object customfield_12076 { get; set; }
    public object customfield_12079 { get; set; }
    public object customfield_11810 { get; set; }
    public object customfield_10601 { get; set; }
    public object customfield_11812 { get; set; }
    public object customfield_11811 { get; set; }
    public object customfield_11814 { get; set; }
    public object aggregatetimeestimate { get; set; }
    public object customfield_10603 { get; set; }
    public object customfield_11813 { get; set; }
    public object customfield_11816 { get; set; }
    public object customfield_11815 { get; set; }
    public object customfield_11818 { get; set; }
    public object customfield_11817 { get; set; }
    public object customfield_11819 { get; set; }
    public Creator creator { get; set; }
    public object[] subtasks { get; set; }
    public object customfield_12066 { get; set; }
    public Reporter reporter { get; set; }
    public object customfield_12068 { get; set; }
    public object customfield_12067 { get; set; }
    public Aggregateprogress aggregateprogress { get; set; }
    public object customfield_12069 { get; set; }
    public Customfield_11403 customfield_11403 { get; set; }
    public object customfield_11807 { get; set; }
    public Progress progress { get; set; }
    public Votes votes { get; set; }
    public object customfield_11808 { get; set; }
    public Issuetype issuetype { get; set; }
    public object timespent { get; set; }
    public object customfield_12055 { get; set; }
    public Project project { get; set; }
    public object customfield_12056 { get; set; }
    public object aggregatetimespent { get; set; }
    public object customfield_11401 { get; set; }
    public object customfield_10303 { get; set; }
    public object customfield_10304 { get; set; }
    public object customfield_10305 { get; set; }
    public object customfield_10702 { get; set; }
    public object customfield_10703 { get; set; }
    public DateTime resolutiondate { get; set; }
    public object customfield_10705 { get; set; }
    public object customfield_10706 { get; set; }
    public object customfield_10707 { get; set; }
    public int workratio { get; set; }
    public Watches watches { get; set; }
    public object customfield_12040 { get; set; }
    public DateTime created { get; set; }
    public object customfield_12044 { get; set; }
    public object customfield_12043 { get; set; }
    public object customfield_12046 { get; set; }
    public object customfield_10300 { get; set; }
    public object customfield_10301 { get; set; }
    public object customfield_11502 { get; set; }
    public string customfield_11105 { get; set; }
    public object customfield_11501 { get; set; }
    public object customfield_11504 { get; set; }
    public object customfield_11900 { get; set; }
    public object customfield_11503 { get; set; }
    public DateTime updated { get; set; }
    public object timeoriginalestimate { get; set; }
    public Customfield_12030 customfield_12030 { get; set; }
    public object customfield_12033 { get; set; }
    public object description { get; set; }
    public object customfield_12032 { get; set; }
    public object customfield_12035 { get; set; }
    public object customfield_11100 { get; set; }
    public object customfield_12034 { get; set; }
    public object customfield_12037 { get; set; }
    public object customfield_12036 { get; set; }
    public object customfield_12039 { get; set; }
    public Customfield_11500 customfield_11500 { get; set; }
    public object customfield_12038 { get; set; }
    public object customfield_11104 { get; set; }
    public object customfield_10005 { get; set; }
    public object customfield_10006 { get; set; }
    public object customfield_12029 { get; set; }
    public object customfield_10403 { get; set; }
    public Customfield_10007 customfield_10007 { get; set; }
    public object security { get; set; }
    public object[] customfield_10800 { get; set; }
    public object customfield_10405 { get; set; }
    public object customfield_10803 { get; set; }
    public object customfield_10805 { get; set; }
    public string summary { get; set; }
    public Customfield_10000 customfield_10000 { get; set; }
    public object[] customfield_10001 { get; set; }
    public object customfield_10002 { get; set; }
    public object customfield_12028 { get; set; }
    public object customfield_10003 { get; set; }
    public object customfield_10400 { get; set; }
    public object customfield_10004 { get; set; }
    public Customfield_11601 customfield_11601 { get; set; }
    public object customfield_11843 { get; set; }
    public object customfield_11600 { get; set; }
    public object customfield_11842 { get; set; }
    public object environment { get; set; }
    public object customfield_11845 { get; set; }
    public object customfield_11603 { get; set; }
    public object customfield_11602 { get; set; }
    public object customfield_11844 { get; set; }
    public object customfield_11847 { get; set; }
    public object customfield_11846 { get; set; }
    public object duedate { get; set; }
  }

  public class Resolution
  {
    public string self { get; set; }
    public string id { get; set; }
    public string description { get; set; }
    public string name { get; set; }
  }

  public class Customfield_12008
  {
    public string languageCode { get; set; }
    public string displayName { get; set; }
  }

  public class Priority
  {
    public string self { get; set; }
    public string iconUrl { get; set; }
    public string name { get; set; }
    public string id { get; set; }
  }

  public class Assignee
  {
    public string self { get; set; }
    public string accountId { get; set; }
    public Avatarurls avatarUrls { get; set; }
    public string displayName { get; set; }
    public bool active { get; set; }
    public string timeZone { get; set; }
    public string accountType { get; set; }
  }

  public class Avatarurls
  {
    public string _48x48 { get; set; }
    public string _24x24 { get; set; }
    public string _16x16 { get; set; }
    public string _32x32 { get; set; }
  }

  public class Status
  {
    public string self { get; set; }
    public string description { get; set; }
    public string iconUrl { get; set; }
    public string name { get; set; }
    public string id { get; set; }
    public Statuscategory statusCategory { get; set; }
  }

  public class Statuscategory
  {
    public string self { get; set; }
    public int id { get; set; }
    public string key { get; set; }
    public string colorName { get; set; }
    public string name { get; set; }
  }

  public class Customfield_12074
  {
    public string self { get; set; }
    public string value { get; set; }
    public string id { get; set; }
  }

  public class Creator
  {
    public string self { get; set; }
    public string accountId { get; set; }
    public Avatarurls1 avatarUrls { get; set; }
    public string displayName { get; set; }
    public bool active { get; set; }
    public string timeZone { get; set; }
    public string accountType { get; set; }
  }

  public class Avatarurls1
  {
    public string _48x48 { get; set; }
    public string _24x24 { get; set; }
    public string _16x16 { get; set; }
    public string _32x32 { get; set; }
  }

  public class Reporter
  {
    public string self { get; set; }
    public string accountId { get; set; }
    public Avatarurls2 avatarUrls { get; set; }
    public string displayName { get; set; }
    public bool active { get; set; }
    public string timeZone { get; set; }
    public string accountType { get; set; }
  }

  public class Avatarurls2
  {
    public string _48x48 { get; set; }
    public string _24x24 { get; set; }
    public string _16x16 { get; set; }
    public string _32x32 { get; set; }
  }

  public class Aggregateprogress
  {
    public int progress { get; set; }
    public int total { get; set; }
  }

  public class Customfield_11403
  {
    public string self { get; set; }
    public string value { get; set; }
    public string id { get; set; }
  }

  public class Progress
  {
    public int progress { get; set; }
    public int total { get; set; }
  }

  public class Votes
  {
    public string self { get; set; }
    public int votes { get; set; }
    public bool hasVoted { get; set; }
  }

  public class Issuetype
  {
    public string self { get; set; }
    public string id { get; set; }
    public string description { get; set; }
    public string iconUrl { get; set; }
    public string name { get; set; }
    public bool subtask { get; set; }
    public int avatarId { get; set; }
  }

  public class Project
  {
    public string self { get; set; }
    public string id { get; set; }
    public string key { get; set; }
    public string name { get; set; }
    public string projectTypeKey { get; set; }
    public bool simplified { get; set; }
    public Avatarurls3 avatarUrls { get; set; }
  }

  public class Avatarurls3
  {
    public string _48x48 { get; set; }
    public string _24x24 { get; set; }
    public string _16x16 { get; set; }
    public string _32x32 { get; set; }
  }

  public class Watches
  {
    public string self { get; set; }
    public int watchCount { get; set; }
    public bool isWatching { get; set; }
  }

  public class Customfield_12030
  {
    public string id { get; set; }
    public string name { get; set; }
    public _Links _links { get; set; }
    public object[] completedCycles { get; set; }
  }

  public class _Links
  {
    public string self { get; set; }
  }

  public class Customfield_11500
  {
    public string self { get; set; }
    public string value { get; set; }
    public string id { get; set; }
  }

  public class Customfield_10007
  {
    public string id { get; set; }
    public string name { get; set; }
    public _Links1 _links { get; set; }
    public object[] completedCycles { get; set; }
  }

  public class _Links1
  {
    public string self { get; set; }
  }

  public class Customfield_10000
  {
    public _Links2 _links { get; set; }
    public Requesttype requestType { get; set; }
    public Currentstatus currentStatus { get; set; }
  }

  public class _Links2
  {
    public string jiraRest { get; set; }
    public string web { get; set; }
    public string self { get; set; }
  }

  public class Requesttype
  {
    public string[] _expands { get; set; }
    public string id { get; set; }
    public _Links3 _links { get; set; }
    public string name { get; set; }
    public string description { get; set; }
    public string helpText { get; set; }
    public string issueTypeId { get; set; }
    public string serviceDeskId { get; set; }
    public string[] groupIds { get; set; }
    public Icon icon { get; set; }
  }

  public class _Links3
  {
    public string self { get; set; }
  }

  public class Icon
  {
    public string id { get; set; }
    public _Links4 _links { get; set; }
  }

  public class _Links4
  {
    public Iconurls iconUrls { get; set; }
  }

  public class Iconurls
  {
    public string _48x48 { get; set; }
    public string _24x24 { get; set; }
    public string _16x16 { get; set; }
    public string _32x32 { get; set; }
  }

  public class Currentstatus
  {
    public string status { get; set; }
    public string statusCategory { get; set; }
    public Statusdate statusDate { get; set; }
  }

  public class Statusdate
  {
    public DateTime iso8601 { get; set; }
    public DateTime jira { get; set; }
    public string friendly { get; set; }
    public long epochMillis { get; set; }
  }

  public class Customfield_11601
  {
    public bool hasEpicLinkFieldDependency { get; set; }
    public bool showField { get; set; }
    public Noneditablereason nonEditableReason { get; set; }
  }

  public class Noneditablereason
  {
    public string reason { get; set; }
    public string message { get; set; }
  }

}
