import { get } from "../services/requestHelpers";

let errmsg = "Error, see console for more";

export const getProducts = async () => {
  try {
    const response = await get("api/getAll");
    return response.data;
  } catch (err) {
    console.log(err);
    return errmsg;
  }
};

export const getProductTestsByDate = async (date) => {
  try {
    const response = await get("products?date=" + date);
    return response.data;
  } catch (err) {
    console.log(err);
    return errmsg;
  }
};

export const getProductTestsBySN = async (sn) => {
  try {
    const response = await get("products?sn=" + sn);
    return response.data;
  } catch (err) {
    console.log(err);
    return errmsg;
  }
};

export const getProductByDeviceName = async (deviceName) => {
  try {
    const response = await get("api/lastTestForEach?deviceName=" + deviceName);
    return response.data;
  } catch (err) {
    console.log(err);
    return errmsg;
  }
};

export const getProductNames = async (deviceName) => {
  try {
    const response = await get("api/productNames");
    return response.data;
  } catch (err) {
    console.log(err);
    return errmsg;
  }
};

export const getProduct = async (id) => {
  try {
    const response = await get("product?id=" + id);
    return response.data;
  } catch (err) {
    console.log(err);
    return errmsg;
  }
};