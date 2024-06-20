# from flask import Flask
from flask import Flask, request, render_template
from pathlib import Path
home= Path().absolute()
app = Flask(__name__)
# print(home)


@app.route('/')
def hello_world():
   return 'Hello World'

@app.route('/start')
def start():
#    return render_template(str(home)+'/ui/start.html',test='h1')
   return render_template('start.html',test='h1',mycode='jj')


@app.route('/hello/<name>')
def hello_name(name):
   return 'Hello %s!' % name

#app.add_url_rule('/', 'hello', hello_world)



if __name__ == '__main__':
   
   app.run(debug = True)
   
  