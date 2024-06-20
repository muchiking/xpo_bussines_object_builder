## Making all necessary library imports
from flask import Flask, request, render_template
from pathlib import Path
from createvars import * 
home= Path().absolute()

app = Flask(__name__)

## Defining the route for the home page
@app.route('/',methods=["GET","POST"])
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
            

            for key, value in request.form.items():
                print(f'{key}: {value}')
                errors += f'{key}: {value}\n'

        return render_template('start.html',test='h1',mycode= mycode,errors=errors)

@app.route('/pricing',methods=["GET","POST"])
def pricing():
    return render_template('pricing.html')

if __name__ == '__main__':
   
   app.run(debug = True)
   
  