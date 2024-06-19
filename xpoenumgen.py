def string_bulder(arry):
    x=" "
    total=len(arry)
    count=0
    for enrty in arry:
        if(count==total-1):
            x+=enrty
            break
        x+=enrty+","
        count=count+1
        #print(count)
    return x

def format_word(word):
    formatted_word = "_" + word[0].upper() + word[1:]

    return formatted_word


def enumprint(name,enumsarry,variablename):
    elements=string_bulder(enumsarry)
    entry=(variablename)
    variablename=format_word(entry)

    enumclass= f'''
   
        private {name} {variablename};
        public {name} {entry}
        {{
            get {{ return  {variablename}; }}
            set {{ SetPropertyValue(nameof( {entry}), ref {variablename}, value); }}
    
        }}

    public enum {name}
            {{
            {elements}
            
            }}'''
    return enumclass


if __name__ == "__main__":
    my_array = ["Enroled","Completed"]
    enumname="TrainingStatusEnum"
    variablename="TrainingStatus"
    test=enumprint(enumname ,my_array,variablename)
    # listname=


    # print(test)
    f =open("xpoenumlist.cs","w")
    f.write(test)
    f.close()
