﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJ1W
{
    class ServiceHandler
    {
        //static InputStream is = null;
        //static String response = null;
        //public final static int GET = 1;
        //public final static int POST = 2;

        public ServiceHandler() {
        }

        /**
         * Making service call
         * @url - url to make request
         * @method - http request method
         * */
        //public String makeServiceCall(String url, int method) {
        //    return this.makeServiceCall(url, method, null);
        //}

        /**
         * Making service call
         * @url - url to make request
         * @method - http request method
         * @params - http request params
         * */
        //public String makeServiceCall(String url, int method, List<NameValuePair> params) {
        //    try {
        //        // http client
        //        DefaultHttpClient httpClient = new DefaultHttpClient();
        //        HttpEntity httpEntity = null;
        //        HttpResponse httpResponse = null;

        //        // Checking http request method type
        //        if (method == POST) {
        //            HttpPost httpPost = new HttpPost(url);
        //            // adding post params
        //            if (params != null) {
        //                httpPost.setEntity(new UrlEncodedFormEntity(params));
        //            }

        //            httpResponse = httpClient.execute(httpPost);

        //        } else if (method == GET) {
        //            // appending params to url
        //            if (params != null) {
        //                String paramString = URLEncodedUtils.format(params, "utf-8");
        //                url += "?" + paramString;
        //            }
        //            HttpGet httpGet = new HttpGet(url);

        //            httpResponse = httpClient.execute(httpGet);

        //        }
        //        httpEntity = httpResponse.getEntity();
        //        is = httpEntity.getContent();

        //    } catch (UnsupportedEncodingException e) {
        //        e.printStackTrace();
        //    } catch (ClientProtocolException e) {
        //        e.printStackTrace();
        //    } catch (IOException e) {
        //        e.printStackTrace();
        //    }

        //    try {
        //        BufferedReader reader = new BufferedReader(new InputStreamReader(is, "UTF-8"), 8);
        //        StringBuilder sb = new StringBuilder();
        //        String line = null;
        //        while ((line = reader.readLine()) != null) {sb.append(line + "\n");
        //        }
        //        is.close();
        //        response = sb.toString();
        //    } catch (Exception e) {
        //        Log.e("Buffer Error", "Error: " + e.toString());
        //    }

        //    return response;
        //}
    }
}