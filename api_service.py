from flask import Flask, request, abort, render_template, send_file, json
from flask_cors import CORS, cross_origin
import pandas as pd
from deepface import DeepFace
import base64
import cv2
import numpy as np

app = Flask(__name__, )
app.config["JSON_AS_ASCII"] = False

CORS(app)
app.config["CORS_HEADERS"] = "Content-Type"

@app.route("/face_register/apiv1/represent", methods=["POST"])
@cross_origin(origin="*")
def representVector():
    response = {
        "code" : "0",
        "success" : True,
        "message" : ""
    }
    
    try:
        request_info = request.json
        base64_string  = request_info["img"]
        model_name = request_info["model"]
        
        im_bytes = base64.b64decode(base64_string)
        im_arr = np.frombuffer(im_bytes, dtype=np.uint8)  # im_arr is one-dim Numpy array
        image = cv2.imdecode(im_arr, flags=cv2.IMREAD_COLOR)
        DeepFace.represent(img_path=image, model_name = model_name, detector_backend='skip', enforce_detection=False)
    except Exception as e:
        response["success"] = False
        response["message"] = str(e.message)
        response["code"] = "99"
        
    return response

def base64toImage(base64_string):
    return None
    
if __name__ == "__main__":    
    app.run(host="0.0.0.0", port="8888", debug=False, threaded=True)