# from flask import Flask
from flask import Flask, request, render_template
from pathlib import Path
from createvars import * 
home= Path().absolute()
app = Flask(__name__)
# print(home)

@app.route('/new', methods=["GET", "POST"])
def new():
    mycode = ''
    errors = 'ee \n'
    if request.method == 'POST':
        print('started route')
        mycode = 'ff'
        for key, value in request.form.items():
            print(f'{key}: {value}')
            errors += f'{key}: {value}\n'
        # Example of accessing individual form data
        # name = request.form.get('name')
        # age = request.form.get('age')
        # Do something with the form data, e.g., call a function
        # varss = createvars.print_entries_in_both_cases(my_array)

    return render_template('new.html', test='h1', mycode=mycode, errors=errors)


@app.route('/')
def hello_world():
   return 'Hello World'

@app.route('/start',methods=["GET","POST"])
def start():
        mycode=''
        errors='ee \n'
        if request.method == 'POST':
            print('started route')
            mycode='ff'

            vartype= request.form.get("vartypes")
            variable = request.form.get("variable")

            variable= variable.split(',')
            print(vartype)
            
            if vartype == 'Int':
                result=createint(variable)
                mycode= result
            elif vartype == 'String':
                result=createstrings(variable)
                mycode= result
            elif vartype == 'Bool':
                result=createbool(variable)
                mycode= result
            elif vartype == 'Double':
                result=createdouble(variable)
                mycode= result
            elif vartype == 'Date':
                result=createdate(variable)
                mycode= result
                

  

           
            # for t in request.form:
            #     print(t)
            #     errors+=t
            
           
            # print(result)
            for key, value in request.form.items():
                print(f'{key}: {value}')
                errors += f'{key}: {value}\n'
            #   print( (request.form) == None)
            #   print( (request.form))

            #   varss = createvars.print_entries_in_both_cases(my_array)
        # name = request.form['name']
        # age = request.form['age']        
        # varss = createvars.print_entries_in_both_cases(my_array)
#    return render_template(str(home)+'/ui/start.html',test='h1')

        return render_template('start.html',test='h1',mycode= mycode,errors=errors)


@app.route('/hello/<name>')
def hello_name(name):
   return 'Hello %s!' % name

#app.add_url_rule('/', 'hello', hello_world)



if __name__ == '__main__':
   
   app.run(debug = True)
   
  