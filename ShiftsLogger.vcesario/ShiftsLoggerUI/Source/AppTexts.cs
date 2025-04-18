public static class AppTexts
{
    public const string FORMAT_DATETIME = "dd/MM/yyyy HH:mm:ss";

    public const string PROMPT_ACTION = "What do you want to do?";
    public const string PROMPT_RECONFIRM = "Are you REALLY sure?";
    public const string PROMPT_NEWSHIFT_WORKERID = "Enter your worker ID:";
    public const string PROMPT_NEWSHIFT_STARTDATETIME = "Start date and time of your shift:";
    public const string PROMPT_NEWSHIFT_ENDDATETIME = "End date and time of your shift:";

    public const string TOOLTIP_RETURN = "Press any key to return.";
    public const string TOOLTIP_CANCEL = "Enter '.' anywhere to cancel.";

    public const string LOG_NEWSHIFT_SUCCESS = "Shift logged successfully.";

    public const string OPTION_ADDSHIFT = "Add new shift";
    public const string OPTION_VIEWALL = "View all shifts";
    public const string OPTION_EDITSHIFT = "Edit shift";
    public const string OPTION_REMOVESHIFT = "Remove shift";
    public const string OPTION_EXIT = "Exit";
    
    public const string LABEL_APPTITLE = "Shifts Logger";
    public const string LABEL_UNDEFINED = "<undefined>";

    public const string LABEL_SHIFTTABLE_ID = "ID";
    public const string LABEL_SHIFTTABLE_WORKERID = "Worker ID";
    public const string LABEL_SHIFTTABLE_STARTTIME = "Start time";
    public const string LABEL_SHIFTTABLE_ENDTIME = "End time";

    public const string ERROR_BADSTARTDATETIME = "Invalid date and time for starting a shift.";
    public const string ERROR_BADENDDATETIME = "Invalid date and time for ending a shift.";
    public const string ERROR_USERINPUT_DATETIME = $"Couldn't parse DateTime. Use template <{FORMAT_DATETIME}>.";
    public const string ERROR_USERINPUT_NUMBER = "Couldn't parse number.";
}