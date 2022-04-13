import { get } from "../services/requestHelpers";

let errmsg = "Error, see console for more";

export const getAllProducts = async () => {
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

export const getLastTestsBySn = async (deviceName) => {
  try {
    const response = await get("api/lastTestsBySn?deviceName=" + deviceName);
    return response.data;
  } catch (err) {
    console.log(err);
    return errmsg;
  }
};

export const getTestGroupsForDevice = async (deviceName, deviceSn) => {
  try {
    const response = await get("api/allTestGroupsForDevice?deviceName=" + deviceName + "&deviceSn=" + deviceSn);
    return response.data;
  } catch (err) {
    console.log(err);
    return errmsg;
  }
};

export const getProductNames = async () => {
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