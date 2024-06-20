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
        private bool {variablename};
        public bool {entry}
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