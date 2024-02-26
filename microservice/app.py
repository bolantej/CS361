#!flask/bin/python
from flask import Flask
import urllib.request, json

app = Flask(__name__)

        
@app.route('/')
def index():
    return "The server is running"


@app.route('/food/<string:name>', methods=['GET'])
def get_cals(name):
    try:
        for i in range(len(name)):
            if name[i] == ' ' or name[i] == '_':
                name = name[0:i] + "%20" + name[i+1:]
        url = "https://api.nal.usda.gov/fdc/v1/foods/search?api_key=OSQ3d8rvZxKkK1dcCPporadhp7L6GsDircmT3Epr&query=" + name +"&numberOfResultsPerPage=1&pageSize=1"

        hdr ={
        'Accept': 'application/json',
        'Cache-Control': 'no-cache',
        }

        req = urllib.request.Request(url, headers=hdr)

        req.get_method = lambda: 'GET'
        response = urllib.request.urlopen(req)
        nutrients = json.loads(response.read().decode("utf-8"))["foods"][0]["foodNutrients"]
        for nutrient in nutrients:
            if nutrient["nutrientId"] == 1008:
                print("found: ", nutrient["value"])
                return str(nutrient["value"])
            
        return "error"
    except Exception as e:
        print(e)

if __name__ == '__main__':
    app.run(debug=True)
