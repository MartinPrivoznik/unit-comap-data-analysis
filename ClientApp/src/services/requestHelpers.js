import axios from "axios";

export const get = async (url) => {
  return axios.get(url, {
    headers: { "Content-Type": "application/json" },
  });
};

export const post = async (url, body) => {
  return axios.post(url, body, {
    headers: { "Content-Type": "application/json" },
  });
};
