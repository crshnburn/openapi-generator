/*
 * Minimal Example 
 * byte Array error in equal method
 *
 * The version of the OpenAPI document: v1
 * 
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */


package org.openapitools.client.api;

import org.openapitools.client.model.ByteArrayObject;
import org.junit.jupiter.api.Disabled;
import org.junit.jupiter.api.Test;

import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Map;
import java.util.stream.Collectors;

/**
 * API tests for DefaultApi
 */
@Disabled
public class DefaultApiTest {

    private final DefaultApi api = new DefaultApi();

    
    /**
     * 
     *
     * 
     */
    @Test
    public void nullableArrayTestGetTest()  {
        List<ByteArrayObject> response = api.nullableArrayTestGet();

        // TODO: test validations
    }
    
}