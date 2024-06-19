import os
# def datetime(obj):
#     string=""
#     for entry in obj:
#         string+=f'public DateTime {entry} {{get; set;}}'
    

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
    # print(string) 


    #print(f"Formatted word: {formatted_word}")

if __name__ == "__main__":
    slave = ['Employee']
    # master is the table that gets collections 
    master = ['Manager']
    vars = print_entries_in_both_cases(master,slave)
    f=open("relationships.cs","w+")
    f.write(vars)
    f.close()


    #tables to reveiw
    #employee
    #care 
