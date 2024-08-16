import random

def format_word(word):
    formatted_word = "_" + word[0].upper() + word[1:]

    return formatted_word

def createstrings(arr):
    string=" "
    for entry in arr:
        #print(f"Uppercase: {entry.upper()}, Lowercase: {entry.lower()}")
        variablename=(format_word(entry))
        functionname=entry
        list= f"""
        private string {variablename};
        public string {entry}
        {{
            get {{ return  {variablename}; }}
            set {{ SetPropertyValue(nameof( {entry}), ref {variablename}, value); }}
    
        }}"""
        string+=list

    return (string)

def createint(arr):
    string=" "
    for entry in arr:
        #print(f"Uppercase: {entry.upper()}, Lowercase: {entry.lower()}")
        variablename=(format_word(entry))
        functionname=entry
        list= f"""
        private int {variablename};
        public int {entry}
        {{
            get {{ return  {variablename}; }}
            set {{ SetPropertyValue(nameof( {entry}), ref {variablename}, value); }}
    
        }}"""
        string+=list

    return (string)

def createbool(arr):
    string=" "
    for entry in arr:
        #print(f"Uppercase: {entry.upper()}, Lowercase: {entry.lower()}")
        variablename=(format_word(entry))
        functionname=entry
        list= f"""
        private bool {variablename};
        public bool {entry}
        {{
            get {{ return  {variablename}; }}
            set {{ SetPropertyValue(nameof( {entry}), ref {variablename}, value); }}
    
        }}"""
        string+=list

    return (string)


def createdate(arr):
    string=" "
    for entry in arr:
        #print(f"Uppercase: {entry.upper()}, Lowercase: {entry.lower()}")
        variablename=(format_word(entry))
        functionname=entry
        list= f"""
        public DateTime {entry} {{get; set;}}
       """
        string+=list

    return (string)

 
def createxpliteobj(arr):
    string=" "
    for entry in arr:
        #print(f"Uppercase: {entry.upper()}, Lowercase: {entry.lower()}")
        variablename=(format_word(entry))
        functionname=entry
        list= f"""
        int {variablename};
        [Key(AutoGenerate = true), Browsable(false)]
        public int {entry}
        {{
            get {{ return  {variablename}; }}
            set {{ SetPropertyValue(nameof( {entry}), ref {variablename}, value); }}
    
        }}"""
        string+=list

    return (string)




def createdouble(arr):
    string=" "
    for entry in arr:
        #print(f"Uppercase: {entry.upper()}, Lowercase: {entry.lower()}")
        variablename=(format_word(entry))
        functionname=entry
        list= f"""
        private double {variablename};
        public double {entry}
        {{
            get {{ return  {variablename}; }}
            set {{ SetPropertyValue(nameof( {entry}), ref {variablename}, value); }}
    
        }}"""
        string+=list

    return (string)

def format_word1(word):
    formatted_word =  word[0].upper() + word[1:]

    return formatted_word

def format_word(word):
    formatted_word = "_" + word[0].upper() + word[1:]

    return formatted_word

def print_entries_in_both_cases(shared,master):
    string=" "
    for i in range(0,len(shared)):
        slave=shared[i]
        masterclass=master[i]
        #print(f"Uppercase: {entry.upper()}, Lowercase: {entry.lower()}")
        sharedsmall=(format_word(slave))
        _masterclass=(format_word(masterclass))
        #functionname=entry
        list= f'''
        private {slave} {sharedsmall};
       [Association("{slave}-{masterclass}")]
        public {slave} {slave}
        {{
            get =>{sharedsmall};
            set => SetPropertyValue(nameof({slave}), ref {sharedsmall}, value);
        }}
        //paste in slave class
        
       [Association("{slave}-{masterclass}")]
        public XPCollection<{masterclass}>{_masterclass} => GetCollection<{masterclass}>(nameof({_masterclass}));'''
        string+=list

    return (string)

def print_entries_in_both_cases1(shared,master):
    string=" "
    slave=shared
    masterclass=master
    # for i in range(0,len(shared)):
    #     slave=shared[i]
    #     masterclass=master[i]
    #     #print(f"Uppercase: {entry.upper()}, Lowercase: {entry.lower()}")
    sharedsmall=(format_word(slave))
    _masterclass=(format_word1(masterclass))
    #functionname=entry
    new=str(random.randint(0000,9999))
    list= f'''
    private {slave} {sharedsmall};
    [Association("{slave}-{masterclass}")]
    public {slave} {slave}
    {{
        get =>{sharedsmall};
        set => SetPropertyValue(nameof({slave}), ref {sharedsmall}, value);
    }}
    //paste in slave {slave}
    
    [Association("{slave}-{masterclass}")]
    public XPCollection<{masterclass}>{_masterclass}_{new} => GetCollection<{masterclass}>(nameof({_masterclass}_{new}));'''
    string+=list

    return (string)